using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprogramming
{
    class User
    {
        private string username;
        private string password;
        private string message;

        public User(string username,string password,string message="")
        {
            this.username = username;
            this.password = password;
            this.message = message;
        }
        public string CheckLogin()
        {
            if(this.username=="Admin" && this.password == "manager")
            {
                this.message = "You are Logged in as Admin";
            }
            else if(this.username.StartsWith("User") && this.password == "Pass123")
            {
                this.message = "You are Logged in as a normal user";
            }
            else
            {
                this.message = "Invalid User";
            }
            return this.message;
        }
    }
}
