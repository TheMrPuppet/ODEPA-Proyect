using ODEPA_.Database;
using ODEPA_.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Controllers
{
    public class Input
    {
        Connection db;

        // CUENTA:

        public bool InsertCuenta(Cuenta item)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            try
            {
                sql = $"insert into cuenta values (" +
                    "       '" + item.Nombre + "', " +
                    "       '" + item.Correo + "', " +
                    "       '" + item.Pw + "');";

                cmd.CommandText = sql;

                db.EjecutarConsulta(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public bool IsCorreoThere(string correo)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            bool issame = false;
            try
            {
                sql = $"Select * from cuenta;";


                cmd.CommandText = sql;

                DataTable dt = db.EjecutarConsulta(cmd);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["correo"].ToString() == correo)
                    {
                        issame = true;
                        break;
                    }
                }
                return issame;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public bool UpdatePW(string correo, string pw)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            try
            {
                sql = $"Update cuenta" +
                    "       set pw='" + pw + "' " +
                    "       where correo='" + correo + "';";

                cmd.CommandText = sql;

                db.EjecutarConsulta(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public bool CheckPW(string correo, string pw)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            bool iscorrect = false;
            try
            {
                sql = $"Select * from cuenta where correo ='"+correo+"';";

                
                cmd.CommandText = sql;

                DataTable dt = db.EjecutarConsulta(cmd);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["pw"].ToString() == pw)
                    {
                        iscorrect= true;
                        break;
                    }
                }
                return iscorrect;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        // PRODUCTO:
        public bool InsertProducto(Producto item)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            try
            {
                sql = $"insert into productos values (" +
                    "       '" + item.ProductName + "', " +
                    "       " + item.ProducerID + ", " +
                    "       " + item.Stock + ", " +
                    "       '" + item.ProductType + "', " +
                    "       " + item.Price + ", " +
                    "       '" + item.SellAdress + "', " +
                    "       '" + item.ProductImage + "');";
                SqlParameter param = cmd.Parameters.Add("@Image", SqlDbType.VarBinary);
                param.Value = item.ProductImage;
                cmd.CommandText = sql;

                db.EjecutarConsulta(cmd);

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ErrorCode);
                Console.WriteLine(ex.Number);
                return false;

            }
        }

        public bool UpdateProducto(Producto item)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            try
            {
                sql = $"update productos" +
                    "       set name='" + item.ProductName + "', " +
                    "       stock=" + item.Stock + ", " +
                    "       type='" + item.ProductType + "', " +
                    "       price=" + item.Price + ", " +
                    "       selladress='" + item.SellAdress + "', " +
                    "       productimage='" + item.ProductImage + "'" +
                    " where productid ="+item.ProductID+";";

                cmd.CommandText = sql;

                db.EjecutarConsulta(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public bool DeleteProducto(int id)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            try
            {
                sql = $"delete from productos where productid=" + id + ";";
                cmd.CommandText = sql;

                db.EjecutarConsulta(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        //PRODUCTOR:

        public bool InsertProductor(Productor item)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            try
            {
                sql = $"insert into productos values (" +
                    "       " + item.Prut + ", " +
                    "       '" + item.Prutid + "', " +
                    "       '" + item.Pnombre + "', " +
                    "       '" + item.Pcorreo + "', " +
                    "       '" + item.Padress + "');";

                cmd.CommandText = sql;

                db.EjecutarConsulta(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public bool UpdateProductor(Productor item)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            try
            {
                sql = $"update productores" +
                    "       set pnombre='" + item.Pnombre + "'," +
                    "       pcorreo='" + item.Pcorreo + "', " +
                    "       padress='" + item.Padress + "'" +
                    " where productid =" + item.Prut + ";";

                cmd.CommandText = sql;

                db.EjecutarConsulta(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public bool DeleteProductor(int rut)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            try
            {
                sql = $"delete from productores where prut=" + rut + ";";
                cmd.CommandText = sql;

                db.EjecutarConsulta(cmd);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        // VENTA Y DETALLE:

        public bool InsertVentaDetalle(Venta item, List<Detalle> list)
        {
            db = new Connection();
            SqlCommand cmd = new();
            cmd.CommandType = CommandType.Text;
            string sql;
            try
            {
                sql = $"insert into ventas values (" +
                    "       '" + item.Clienterut + "', " +
                    "       '" + item.Producerrut + "', " +
                    "       TO_DATE('" + item.Fecha.ToString("dd/MM/yyyy") + "','dd/MM/yyyy'), " +
                    "       " + item.Total + ");";

                cmd.CommandText = sql;

                db.EjecutarConsulta(cmd);

                foreach(var d in list)
                {
                    sql = $"insert into detalle values (" +
                    "       " + d.Ventaid + ", " +
                    "       " + d.Productid + ", " +
                    "       " + d.Cantidad + ");";

                    cmd.CommandText = sql;

                    db.EjecutarConsulta(cmd);

                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

    }
}
