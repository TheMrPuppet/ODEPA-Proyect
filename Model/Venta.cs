using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Model
{
    public class Venta
    {
        private int ventaid;
        private int clienterut;
        private int producerrut;
        private DateTime fecha;
        private int total;

        public Venta() { }
        public Venta(int ventaid, int clienterut, int producerrut, DateTime fecha, int total)
        {
            this.ventaid = ventaid;
            this.clienterut = clienterut;
            this.producerrut = producerrut;
            this.fecha = fecha;
            this.total = total;
        }

        public int Ventaid { get => ventaid; set => ventaid = value; }
        public int Clienterut { get => clienterut; set => clienterut = value; }
        public int Producerrut { get => producerrut; set => producerrut = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Total { get => total; set => total = value; }
    }
}
