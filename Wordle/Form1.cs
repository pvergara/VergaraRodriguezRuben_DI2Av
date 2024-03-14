using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VergaraRodriguezRuben_DI2Av;

namespace Wordle
{
    public partial class Form1 : Form
    {
        private Baldosa[,] buttons = new Baldosa[6,5];
        private List<Usuario> users = new List<Usuario>();
        private string[] _words = new[] { "LITRO", "VELAS", "CINCO", "LUNES", "MARCO", "CALDO", "ADIOS" };
        private readonly int _selectedWordInt;
        private string _selectedWord;

        public Form1()
        {
            
            InitializeComponent();
            this._selectedWordInt = new Random().Next(0, 6);
            this._selectedWord = _words[this._selectedWordInt];
            this.Text = _selectedWord;
            users.Add(new Usuario("pep",-1));
            users.Add(new Usuario("ito",-1));
            users.Add(new Usuario("pepo",2));
            users.Add(new Usuario("te",3));
            this.lstUsuarios.DataSource = users;
            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    buttons[i, j] = new Baldosa();
                    buttons[i, j].Location = new Point((200+ (25 * i)), 10+(30*j));
                    buttons[i, j].Visible = false;
                    buttons[i, j].Font = new Font("Verdana", 18);
                    buttons[i, j].MouseEnter += this.MouseEntered;
                    buttons[i, j].MouseLeave += this.MouseLeft;
                    this.Controls.Add(buttons[i,j]);
                }
            }
            txtPalabra.AcceptsReturn = true;
            txtPalabra.AcceptsTabChanged += this.txtEntered;
        }

        private void txtEntered(object sender, EventArgs e)
        {
            if (this.txtPalabra.Text.Length != 5)
            {
                return;
            }
            string textWord = this.txtPalabra.Text;
            for (int i = 0; i < textWord.Length; i++)
            {
                 Comprueba(textWord[i], i);
            }
        }

        private void MouseLeft(object sender, EventArgs e)
        {
            ((Baldosa)sender).BackColor = Color.Black;
        }

        private void MouseEntered(object sender, EventArgs e)
        {
            ((Baldosa)sender).BackColor = Color.AliceBlue;
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                buttons[i, 0].Visible = true;
                for (int j = 0; j < 5; j++)
                {
                    buttons[i, j].Visible = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.users= this.users.Where(u => u.Intentos != -1).ToList();

            UserForm userForm = new UserForm();
            userForm.ShowDialog();

            this.users.Add(new Usuario(userForm.usuario,-1));
            this.lstUsuarios.DataSource = this.users;
            this.lstUsuarios.ResetBindings();
        }

        private int Comprueba(char letra, int posicion)
        {
            if (_selectedWord[posicion]==letra)
            {
                return 3;
            }

            if (_selectedWord.Contains(letra))
            {
                return 2;
            }
            return 1;
        }
    }
}
