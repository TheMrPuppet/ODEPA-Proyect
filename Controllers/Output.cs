using ODEPA_.Database;
using ODEPA_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Drawing;

namespace ODEPA_.Controllers
{
    public class Output
    {
        public List<Producto> ListarProductos(int id)
        {
            List<Producto> lista = new();
            Producto product;
            Connection db;
            string sql = "select * from productos;";
            if (id != -1)
                sql = "select * from productos where producerid=" + id + " ;";
            try
            {

                SqlCommand cmd = new()
                {
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                db = new Connection();
                DataTable dt = db.EjecutarConsulta(cmd);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    product = new Producto();
                    product.ProductID = int.Parse(dt.Rows[i]["productid"].ToString());
                    product.ProductName = dt.Rows[i]["name"].ToString();
                    product.ProducerID = int.Parse(dt.Rows[i]["producerid"].ToString());
                    product.Stock = int.Parse(dt.Rows[i]["stock"].ToString());
                    product.ProductType = dt.Rows[i]["type"].ToString();
                    product.Price = float.Parse(dt.Rows[i]["price"].ToString());
                    product.SellAdress = dt.Rows[i]["selladress"].ToString();
                    product.ProductImage = dt.Rows[i]["productimage"].ToString();
                    lista.Add(product);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public List<Productor> ListarProductores(int id)
        {
            List<Productor> lista = new();
            Productor productor;
            Connection db;
            string sql = "select * from productores;";
            if (id != -1)
                sql = "select * from productores where prut=" + id + " ;";
            try
            {

                SqlCommand cmd = new()
                {
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                db = new Connection();
                DataTable dt = db.EjecutarConsulta(cmd);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    productor = new Productor();
                    productor.Prut = int.Parse(dt.Rows[i]["prut"].ToString());
                    productor.Prutid = dt.Rows[i]["prutid"].ToString();
                    productor.Pnombre = dt.Rows[i]["pnombre"].ToString();
                    productor.Pcorreo = dt.Rows[i]["pcorreo"].ToString();
                    productor.Padress = dt.Rows[i]["padress"].ToString();


                    lista.Add(productor);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public List<Venta> ListarVentas(int id)
        {
            List<Venta> lista = new();
            Venta venta;
            Connection db;
            string sql = "select * from ventas;";
            if (id != -1)
                sql = "select * from ventas where ventaid=" + id + " ;";
            try
            {

                SqlCommand cmd = new()
                {
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                db = new Connection();
                DataTable dt = db.EjecutarConsulta(cmd);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    venta = new Venta();
                    venta.Ventaid = int.Parse(dt.Rows[i]["ventaid"].ToString());
                    venta.Clienterut = int.Parse(dt.Rows[i]["clientrut"].ToString());
                    venta.Producerrut = int.Parse(dt.Rows[i]["producerrut"].ToString());
                    venta.Fecha = DateTime.Parse(dt.Rows[i]["fecha"].ToString());
                    venta.Total = double.Parse(dt.Rows[i]["total"].ToString());


                    lista.Add(venta);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public List<Detalle> ListarDetalles(int id)
        {
            List<Detalle> lista = new();
            Detalle detalle;
            Connection db;
            string sql = "select * from detalle;";
            if (id != -1)
                sql = "select * from detalle where detalleid=" + id + " ;";
            try
            {

                SqlCommand cmd = new()
                {
                    CommandType = CommandType.Text,
                    CommandText = sql
                };
                db = new Connection();
                DataTable dt = db.EjecutarConsulta(cmd);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    detalle = new Detalle();
                    detalle.Detalleid = int.Parse(dt.Rows[i]["detalleid"].ToString());
                    detalle.Ventaid = int.Parse(dt.Rows[i]["ventaid"].ToString());
                    detalle.Productid = int.Parse(dt.Rows[i]["productid"].ToString());
                    detalle.Cantidad = int.Parse(dt.Rows[i]["cantidad"].ToString());


                    lista.Add(detalle);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }


    }
}
