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
        private int price;
        private string sellAdress;
        private double latitude;
        private double longitude;
        private byte[] productImage;

        public Producto() { }

        public Producto(int productID, string productName, int producerID, int stock, string productType, 
            int price, string sellAdress, double latitude, double longitude, byte[] productImage)
        {
            this.productID = productID;
            this.productName = productName;
            this.producerID = producerID;
            this.stock = stock;
            this.productType = productType;
            this.price = price;
            this.sellAdress = sellAdress;
            this.latitude = latitude;
            this.longitude = longitude;
            this.productImage = productImage;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProducerID { get => producerID; set => producerID = value; }
        public int Stock { get => stock; set => stock = value; }
        public string ProductType { get => productType; set => productType = value; }
        public int Price { get => price; set => price = value; }
        public string SellAdress { get => sellAdress; set => sellAdress = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public byte[] ProductImage { get => productImage; set => productImage = value; }
    }
}
