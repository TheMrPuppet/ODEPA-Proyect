using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Model
{
    public class Detalle
    {
        private int detalleid;
        private int ventaid;
        private int productid;
        private int cantidad;

        public Detalle() { }
        public Detalle(int detalleid, int ventaid, int productid, int cantidad)
        {
            this.Detalleid = detalleid;
            this.Ventaid = ventaid;
            this.Productid = productid;
            this.Cantidad = cantidad;
        }

        public int Detalleid { get => detalleid; set => detalleid = value; }
        public int Ventaid { get => ventaid; set => ventaid = value; }
        public int Productid { get => productid; set => productid = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
