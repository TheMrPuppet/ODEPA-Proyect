using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Model
{
    public class Cuenta
    {
        private int rut;
        private string rutid;
        private string nombre;
        private string correo;
        private string pw;

        public Cuenta() { }
        public Cuenta(int rut, string rutid, string nombre, string correo, string pw)
        {
            this.rut = rut;
            this.rutid = rutid;
            this.nombre = nombre;
            this.correo = correo;
            this.pw = pw;
        }

        public int Rut { get => rut; set => rut = value; }
        public string Rutid { get => rutid; set => rutid = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Pw { get => pw; set => pw = value; }
    }
}
