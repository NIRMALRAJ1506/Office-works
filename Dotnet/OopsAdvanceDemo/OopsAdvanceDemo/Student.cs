using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAdvanceDemo
{
    internal class Student:Person
    {
        public int studentId { get; set; }
        public int Marks { get; set; }

        public override string getDetails()
        {
            return "FirstName: " + firstName + "\n" + "LastName: " + lastName + "\n" + "Gender: " + Gender+"\n"
                +"Student ID: "+this.studentId+"\n"+"Student Mark: "+this.Marks;
        }
        
    }
}
