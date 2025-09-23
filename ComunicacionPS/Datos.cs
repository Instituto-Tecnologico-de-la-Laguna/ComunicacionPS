using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ComunicacionPS
{
    internal class Datos
    {
        private MySqlConnection ObtenerConexion()
        {
            try
            {
                string cadenaConexion = "Server=localhost;Database=Programables;Uid=luis;Pwd=joseluis;";
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }

        public bool GuardarDatos(string dato)
        {
            try {
                MySqlConnection conn= ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand("Insert Into Temperaturas(temperatura) " +
                    "Values('" + dato + "')",conn);
                cmd.ExecuteNonQuery();                
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al guardar los datos: " + ex.Message);
                return false;
            }
        }

    }
}
