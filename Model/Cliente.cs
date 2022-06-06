using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Model
{
    public class Cliente
    {
        private int clienterut;
        private string clienterutid;
        private string nombre;
        private string correo;

        public Cliente() { }
        public Cliente(int clienterut, string clienterutid, string nombre, string correo)
        {
            this.Clienterut = clienterut;
            this.Clienterutid = clienterutid;
            this.Nombre = nombre;
            this.Correo = correo;
        }

        public int Clienterut { get => clienterut; set => clienterut = value; }
        public string Clienterutid { get => clienterutid; set => clienterutid = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
