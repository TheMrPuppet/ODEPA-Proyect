using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Model
{
    public class Item
    {
        public Producto producto;

        public int cantidad;

        public Item() { }
        public Item(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }
    }
}
