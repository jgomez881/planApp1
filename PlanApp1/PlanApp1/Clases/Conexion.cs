using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Agregamos paquetes de mysql

namespace UsuariosMysql.Clases
{
    public class Conexion //Para poder acceder a esta desde otras clases
    {
        public MySqlConnection conexion; //Variable que me avisa si estoy conectado o no

        public Conexion() //Constructor para establecer la conexion
        {
            conexion = new MySqlConnection("server=127.0.0.1; port=3306; database=planappdb; Uid=root; pwd=eafit402*; "); // Le paso los parametros para la conexion
        }

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}

