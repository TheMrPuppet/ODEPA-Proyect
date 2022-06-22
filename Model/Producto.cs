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
        private string productImage;

        public Producto() { }

        public Producto(int productID, string productName, int producerID, int stock, string productType,
            float price, string sellAdress, string productImage)
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
        public string ProductImage { get => productImage; set => productImage = value; }

    }
}

   
