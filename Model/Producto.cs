using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace ODEPA_.Model
{
    public class Producto
    {
        private int productID;
        private string productName;
        private int producerID;
        private int stock;
        private string productType;
        private float price;
        private string sellAdress;
        private byte[] productImage;

        public Producto() { }

        public Producto(int productID, string productName, int producerID, int stock, string productType,
            float price, string sellAdress, byte[] productImage)
        {
            this.productID = productID;
            this.productName = productName;
            this.producerID = producerID;
            this.stock = stock;
            this.productType = productType;
            this.price = price;
            this.sellAdress = sellAdress;
            this.productImage = productImage;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProducerID { get => producerID; set => producerID = value; }
        public int Stock { get => stock; set => stock = value; }
        public string ProductType { get => productType; set => productType = value; }
        public float Price { get => price; set => price = value; }
        public string SellAdress { get => sellAdress; set => sellAdress = value; }

        internal bool Actualizar(int productID, string productName, int stock, string productType, float price, string productImage)
        {
            throw new NotImplementedException();
        }

        public byte[] ProductImage { get => productImage; set => productImage = value; }
    }

    //-------------------MÉTODOS--------------------------------------------------
    public List<Producto> listar()
    {
        var productos = new List<Producto>();
        string cadena = "SELECT * FROM PRODUCTO";
        try
        {
            using (var contenedor = new Model1())
            {
                productos = contenedor.Database.SqlQuery<Producto>(cadena).ToList();
            }
        }
        catch (Exception)
        {

            //throw;
        }
        return productos;
    }

    public Boolean Insertar(int productID, string productName, int stock, string productType, float price, string productImage)
    {
        bool estado = false;
        string cadena = "'" + productID + "',";
        cadena = cadena + "'" + productID + "',";
        cadena = cadena + "'" + stock + "'";
        cadena = cadena + "'" + productType + "'";
        cadena = cadena + "'" + price + "'";
        cadena = cadena + "'" + productImage + "'";
        try
        {
            using (var cnx = new Model1())
            {
                int r = cnx.Database.ExecuteSqlCommand("INSERT INTO PRODUCTO VALUES (" + cadena + ")");
                if (r == 1)
                {
                    estado = true;
                }
            }
        }
        catch (Exception)
        {
            estado = false;
            //throw;
        }
        return estado;
    }
    public Producto un_registro(int productID)
    {
        var registro = new Producto();
        try
        {
            using (var cnx = new Model1())
            {
                registro = cnx.Producto.Where(a => a.id_alu == productID).Single();
            }
        }
        catch (Exception)
        {

            //throw;
        }
        return registro;
    }

    public Boolean Actualizar(int productID, string productName, int stock, string productType, float price, string productImage)
    {
        bool estado = false;
        string cadena = "id_pro='" + productID + "', nombre_pro='" + productName + "', stock='" + stock + "', tipo_pro='" + productType + "', precio='" + price + "', img='" + productImage + "'";
        try
        {
            using (var cnx = new Model1())
            {
                int r = cnx.Database.ExecuteSqlCommand("UPDATE PRODUCTO SET " + cadena + " WHERE id_pro=" + productID);
                if (r == 1)
                {
                    estado = true;
                }
            }
        }
        catch (Exception)
        {
            estado = false;
            //throw;
        }
        return estado;
    }

    public Boolean Eliminar(int productID)
    {
        bool estado = false;
        try
        {
            using (var cnx = new Model1())
            {
                int r = cnx.Database.ExecuteSqlCommand("DELETE FROM PRODUCTO WHERE id_pro=" + productID);
                if (r == 1)
                {
                    estado = true;
                }
            }
        }
        catch (Exception)
        {
            estado = false;
            //throw;
        }
        return estado;
    }


}



}
