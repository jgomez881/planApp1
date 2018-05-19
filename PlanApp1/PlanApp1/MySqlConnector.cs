using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace PlanApp1
{
    public class MySqlConnector
    {

        string usr;
        string pass;

        public MySqlConnector(string user, string password) {
            usr = user;
            pass = password;
        }

        MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder();

        public bool Connect(out string Error) {
            Builder.Server = "10.131.137.177";
            Builder.Database = "PlanApp";
            Builder.UserID = usr;
            Builder.Password = pass;
            try {
                MySqlConnection conn = new MySqlConnection(Builder.ToString());
                conn.Open();
                Error = "";
                return true;
            }
            catch(Exception ex) {
                Error = ex.ToString();
                return false;
            }
        }
       
    }
}
