using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Entidades
{
    //Clase que permite la conexción con una base de datos.
    public static class ConectorBaseDatos
    {
        #region Atributos

        static SqlConnection conexion;
        static SqlCommand comando;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que establece la conexion con la base.Se conectara a la base de datos Ferreteria y a la tabla Facturas.
        /// </summary>
        static ConectorBaseDatos()
        {
            ConectorBaseDatos.conexion = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = Ferreteria; Integrated Security = True");
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método de clase que obtiene los registros de la tabla Facturas.
        /// </summary>
        /// <returns>Lista con objetos de tipo Factura.</returns>
        public static List<Factura> ObtenerListaFacturas()
        {
            List<Factura> lista = new List<Factura>();

            try
            {
                ConectorBaseDatos.comando = new SqlCommand();
                ConectorBaseDatos.comando.CommandType = CommandType.Text;
                ConectorBaseDatos.comando.Connection = ConectorBaseDatos.conexion;
                ConectorBaseDatos.comando.CommandText = "SELECT * FROM [Ferreteria].[dbo].[Facturas]";

                ConectorBaseDatos.conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    lista.Add(new Factura(int.Parse(oDr["id"].ToString()),
                                           int.Parse(oDr["nrofactura"].ToString()),
                                           float.Parse(oDr["precioparcial"].ToString()),
                                            ConectorBaseDatos.ConvertirAMedioDePago(oDr["mediopago"].ToString()),
                                            float.Parse(oDr["preciototal"].ToString())));
                }

                oDr.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (ConectorBaseDatos.conexion.State == ConnectionState.Open)
                {
                    ConectorBaseDatos.conexion.Close();
                }
            }

            return lista;
        }




        #endregion

        #region Insetar Factura
        /// <summary>
        /// Método de clase que agrega una factura a la base de datos.
        /// </summary>
        /// <param name="fact">Factura agregar.</param>
        /// <returns>True si se pudo hacer la operación o false si hubo error.</returns>
        public static bool InsertarFactura(Factura fact)
        {
            bool todoOk = false;
            string sql;

            try
            {
                ConectorBaseDatos.comando = new SqlCommand();
                ConectorBaseDatos.comando.Connection = ConectorBaseDatos.conexion;
                ConectorBaseDatos.comando.CommandType = CommandType.Text;

                sql = "INSERT INTO [Ferreteria].[dbo].[Facturas] VALUES (@nrofactura, @precioparcial, @mediopago, @preciototal)";

                ConectorBaseDatos.comando.Parameters.AddWithValue("@nrofactura", fact.NroFactura);
                ConectorBaseDatos.comando.Parameters.AddWithValue("@precioparcial", fact.PrecioParcial);
                ConectorBaseDatos.comando.Parameters.AddWithValue("@mediopago", fact.MedioPago.ToString());
                ConectorBaseDatos.comando.Parameters.AddWithValue("@preciototal", fact.PrecioTotal);
               

                ConectorBaseDatos.comando.CommandText = sql;

                ConectorBaseDatos.conexion.Open();

                ConectorBaseDatos.comando.ExecuteNonQuery();

                todoOk = true;

                ConectorBaseDatos.conexion.Close();
            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (ConectorBaseDatos.conexion.State == ConnectionState.Open)
                {
                    ConectorBaseDatos.conexion.Close();
                }
            }

            return todoOk;
        }

        #endregion

       

        #region Eliminar Factura
        /// <summary>
        /// Método de clase que elimina la factura recibida como parámetro.
        /// </summary>
        /// <param name="fact">Factura a eliminar de la base de datos.</param>
        /// <returns>True si pudo eliminar la factura de la base de datos o false si hubo error.</returns>
        public static bool EliminarFactura(Factura fact)
        {
            bool todoOk = false;
            string sql;

            try
            {
                ConectorBaseDatos.comando = new SqlCommand();

                ConectorBaseDatos.comando.CommandType = CommandType.Text;

                ConectorBaseDatos.comando.Connection = ConectorBaseDatos.conexion;

                ConectorBaseDatos.comando.Parameters.AddWithValue("@id", fact.Id);
                sql = "DELETE FROM Facturas WHERE id = @id";

                ConectorBaseDatos.comando.CommandText = sql;

                ConectorBaseDatos.conexion.Open();

                ConectorBaseDatos.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (ConectorBaseDatos.conexion.State == ConnectionState.Open)
                {
                    ConectorBaseDatos.conexion.Close();
                }
            }

            return todoOk;
        }

        #endregion

        /// <summary>
        /// Método de clase que retorna el valor de enumerado equivalente a la cadena alamcenada en el campo mediopago de
        /// la base de datos.
        /// </summary>
        /// <param name="cadena">Cadena a evaluar.</param>
        /// <returns>El valor del enumerado de tipo MedioPago euivalnete a la cadena recibida por parámetro.</returns>
        public static Factura.EMedioPago ConvertirAMedioDePago(string cadena)
        {
            Factura.EMedioPago respuesta = 0;

            switch (cadena)
            {
                case "Efectivo":
                    respuesta = Factura.EMedioPago.Efectivo;
                    break;
                case "Debito":
                    respuesta = Factura.EMedioPago.Debito;
                    break;
                case "MercadoPago":
                    respuesta = Factura.EMedioPago.MercadoPago;
                    break;
            }

            return respuesta;
        }
    }
}
