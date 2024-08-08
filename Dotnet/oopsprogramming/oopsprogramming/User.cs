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
        private string address;
        private bool isMarried;

        public User(string username,string password,string message="")
        {
            this.username = username;
            this.password = password;
            this.message = message;
        }

        public User(string username,string password,string message,string address)
        {
            this.username=username;
            this.password=password;
            this.message = message;
        }

        public User(string username, string password, string message, string address,bool isMarried)
        {
            this.username = username;
            this.password = password;
            this.message = message;
        }

        public void getDetails()
        {
            Console.WriteLine("Username: "+username);
            Console.WriteLine("Password: "+password);

            if (this.address != null)
            {
                Console.WriteLine("Address: "+this.address);
            }
            Console.WriteLine("Is Married: "+this.isMarried);
        }
        public string CheckLogin()
        {
            if(this.username=="Admin" && this.password == "manager")
            {
                if (this.message == null)
                {
                    this.message = "You are Logged in as Admin";
                }

            }
            else if(this.username.StartsWith("User") && this.password == "Pass123")
            {
                if (this.message == null)
                {
                    this.message = "You are Logged in as a normal user";
                }
            }
            else
            {
                if (this.message == null)
                {
                    this.message = "Invalid User";
                }
            }
            return this.message;
        }
    }
}
