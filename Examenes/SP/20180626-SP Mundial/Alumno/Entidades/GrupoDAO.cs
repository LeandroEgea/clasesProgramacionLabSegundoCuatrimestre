using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GrupoDAO
    {
        //Crear la clase GrupoDAO, la cual proveerá el acceso a los datos de la base para la clase Grupo.
        public static SqlConnection conexion;
        public static SqlCommand comando;

        static GrupoDAO()
        {
            string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=mundial-sp-2018; Integrated Security = True";

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

        public static List<Equipo> Leer(Letras grupo)
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo equipo;

            string consulta = String.Format("Select * from equipos where grupo='{0}'", grupo.ToString());
            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int id = int.Parse(oDr["id"].ToString());
                    string nombre = oDr["nombre"].ToString();
                    equipo = new Equipo(id, nombre);
                    equipos.Add(equipo);
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

            return equipos;
        }
    }
}
