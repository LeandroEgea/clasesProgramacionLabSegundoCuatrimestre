using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public static class LocalDAO
    {
        public static SqlConnection conexion;
        public static SqlCommand comando;

        static LocalDAO()
        {
            string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=Centralita; Integrated Security = True";

            try
            {
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Guardar(Local local)
        {
            bool respuesta = false;
            CultureInfo cul = new CultureInfo("en-EN");

            try
            {
                string consulta = String.Format(cul, "INSERT INTO Llamada (Duracion, Origen, Destino, Costo, Tipo) " +
                    "VALUES ({0}, '{1}', '{2}', {3}, {4})", local.Duracion, local.NroOrigen, local.NroDestino, local.Costo, 0);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return respuesta;
        }

        public static List<Local> Leer(string origen)
        {
            List<Local> locales = new List<Local>();
            Local local;

            string consulta = String.Format("Select * from Llamada where origen='{0}' AND Tipo=0 ORDER BY ID DESC", origen);
            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int id = int.Parse(oDr["ID"].ToString());
                    float duracion = float.Parse(oDr["Duracion"].ToString());
                    string origenDB = oDr["Origen"].ToString();
                    string destino = oDr["Destino"].ToString();
                    float costo = float.Parse(oDr["Costo"].ToString());
                    local = new Local(origenDB, duracion, destino, costo);
                    locales.Add(local);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return locales;
        }
    }
}
