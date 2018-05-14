using System;
using System.Collections.Generic;
using System.Text;

namespace PlanApp1
{
    public class User
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public int phone { get; set; }

        public User() {
        }

        public User(int pUserID, string pName, string pLastname, string pEmail, int pPhone)
        {
            this.user_id = pUserID;
            this.name = pName;
            this.lastname = pLastname;
            this.email = pEmail;
            this.phone = pPhone;
        }
    }
}
