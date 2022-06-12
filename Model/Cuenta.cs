using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Model
{
    public class Cuenta
    {
        private string nombre;
        private string correo;
        private string pw;

        public Cuenta() { }
        public Cuenta(string nombre, string correo, string pw)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.pw = pw;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Pw { get => pw; set => pw = value; }
    }
}
