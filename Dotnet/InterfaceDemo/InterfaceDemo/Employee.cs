using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Employee : IAddress, IContact
    {
        public string EmpName {  get; set; }
        public string addressline1 { get ; set ; }
        public string city { get ; set ; }
        public string state { get ; set ; }
        public int postcode { get ; set ; }
        public string email { get ; set ; }
        public int mobile { get ; set ; }

        public void AddressDetails()
        {
            Console.WriteLine("Company Name: " + this.EmpName);
            Console.WriteLine("Address Line 1: " + this.addressline1 + "\n" + "City: " + this.city + "\n" + "State: " + this.state + "\n" + "PostCode: " + this.postcode);
        }

        public void ContactDetails()
        {
            Console.WriteLine("Email: " + this.email + "\n" + "Mobile Number:" + this.mobile);
        }
    }
}
