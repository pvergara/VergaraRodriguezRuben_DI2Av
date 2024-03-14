using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{
    public partial class UserForm : Form
    {
        public string usuario { get; private set; }

        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.usuario = this.textBox1.Text;
            Close();
        }
    }
}
