using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UsuariosMysql.Clases
{
    class Usuario
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Confirm { get; set; }


        public Usuario()
        {

        }

        public Usuario(string pFirstName, string pLastName, string pEmail, String pPhone, String pPassword, String Pconfirm)
        {
            this.FirstName = pFirstName;
            this.LastName = pLastName;
            this.Email = pEmail;
            this.Phone = pPhone;
            this.Password = pPassword;
            this.Confirm = Pconfirm;
        }

        public static int AgregarUsuario(MySqlConnection conexion, Usuario pUsuario)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO usuario (firstname, lastname, email, phone, password, confirm) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", pUsuario.FirstName, pUsuario.LastName, pUsuario.Email, pUsuario.Phone, pUsuario.Password, pUsuario.Confirm), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        /*public static List<Usuario> BuscarUsuario(MySqlConnection conexion, string pNombre, string pApellido, string pEmail)
        {
            List<Usuario> ListaUsuarios = new List<Usuario>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT id_usuario, nombre, apellido, email FROM usuario WHERE nombre LIKE ('%{0}%') AND apellido LIKE ('%{1}%') AND email LIKE ('%{2}%')", pNombre, pApellido, pEmail), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Usuario pUsuario = new Usuario();
                pUsuario.id_usuario = reader.GetInt32(0);
                pUsuario.nombre = reader.GetString(1);
                pUsuario.apellido = reader.GetString(2);
                pUsuario.email = reader.GetString(3);

                ListaUsuarios.Add(pUsuario);
            }

            return ListaUsuarios;
        }

        //public static int ActualizarUsuario()
        //{

        //}

        //public static int EliminarUsuario()
        //{

        //}

        public static Usuario ObtenerUsuario(MySqlConnection conexion, int pIdUsuario)
        {
            Usuario pUsuario = new Usuario();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT id_usuario, nombre, apellido, email FROM usuario WHERE id_usuario LIKE ('%{0}%')", pIdUsuario), conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                pUsuario.id_usuario = reader.GetInt32(0);
                pUsuario.nombre = reader.GetString(1);
                pUsuario.apellido = reader.GetString(2);
                pUsuario.email = reader.GetString(3);
            }

            return pUsuario;
        }
    }*/
    }
}