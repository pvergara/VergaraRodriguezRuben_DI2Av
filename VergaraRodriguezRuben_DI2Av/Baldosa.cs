using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VergaraRodriguezRuben_DI2Av
{
    [DefaultEvent("Click")]
    public partial class Baldosa: UserControl
    {

        private bool verLetra;
        [Category("Examen")]
        [Description("'Visible' property of the label")]
        public bool VerLetra
        {
            set
            {
                this.verLetra = value;
                this.lbl.Visible = this.verLetra;
            }
            get
            {
                return this.verLetra;
            }
        }


        private string txt="";

        [Category("Examen")]
        [Description("'Text' property from the label")]
        public string Txt
        {
            set
            {
                
                this.txt = value;
                
            }
            get
            {
                if (this.txt.Length>1)
                {
                    this.txt = this.txt.Substring(0, 1).Trim();
                }   
                this.lbl.Text = this.txt;
                return this.txt;
            }
        }

        private int colores;
        [Category("Examen")]
        public int Colores
        {
            set
            {
                if (value >3 || value < 0)
                {
                    throw new ColorNoValidoException();
                }
                this.colores = value;
                this.lbl.ForeColor = Color.White;
                if (this.colores == 0)
                {
                    this.lbl.ForeColor = Color.Black;
                }

                if (value == 3)
                    this.OnAciertoEvent(EventArgs.Empty);
                Refresh();
            }
            get
            {
                return this.colores;
            }
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event EventHandler AciertoEvent;

        private void OnAciertoEvent(EventArgs e)
        {
                this.AciertoEvent?.Invoke(this,e);
        }

        private Color[] _colors = new []{Color.White, Color.Gray, Color.Gold, Color.Green};

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            
            SolidBrush pen=new SolidBrush(_colors[this.colores]);
            int initialCoordinate = 2;
            e.Graphics.FillRectangle(pen,initialCoordinate,initialCoordinate,this.Width-(initialCoordinate*2),this.Height-(initialCoordinate*2));
            
        }

        //AciertoEvent es cosa tuya


        public Baldosa()
        {
            InitializeComponent();

            this.Height = this.Font.Height + 10;
            this.Width = this.Height;
            this.lbl.Height = this.Height;
            this.lbl.Width = this.Width;
            this.lbl.ForeColor = Color.White;
            this.lbl.BackColor = Color.Transparent;
            
            this.lbl.Font = this.Font;
            this.Colores = 0;
            this.VerLetra = false;

        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Baldosa_Resize(object sender, EventArgs e)
        {
            this.lbl.Size = this.Size;
            this.lbl.TextAlign = ContentAlignment.MiddleCenter;
        }
    }

    public class ColorNoValidoException : Exception
    {
    }
}
