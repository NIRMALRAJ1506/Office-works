using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAdvanceDemo
{
    abstract class Person
    {
        public string? firstName;
        public string? lastName;
        public string? Gender;



        public abstract string getDetails();
        
    }
}
