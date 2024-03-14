using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    internal class Usuario
    {
        public string Nombre { set; get; }
        public int Intentos { set; get; }


        public override string ToString()
        {
            return Nombre + " " + Intentos;
        }

        public Usuario(string nombre, int intentos)
        {
            Nombre = nombre;
            Intentos = intentos;
        }
    }
}
