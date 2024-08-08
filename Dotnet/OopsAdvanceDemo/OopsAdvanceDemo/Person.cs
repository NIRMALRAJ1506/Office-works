using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAdvanceDemo
{
    internal class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Gender { get; set; }

        public Person(string fname,string lname,string gen)
        {
            firstName = fname;
            lastName = lname;
            Gender = gen;
        }

        public void getDetails()
        {
            Console.WriteLine("First Name: "+this.firstName);
            Console.WriteLine("Last Name: "+this.lastName);
            Console.WriteLine("Gender: "+this.Gender);
        }
    }
}
