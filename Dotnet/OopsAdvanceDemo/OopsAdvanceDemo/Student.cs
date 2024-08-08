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

        public Student(string firstName,string lastName,string Gender,int studentId,int Marks):base( firstName, lastName, Gender)
        {
            this.studentId = studentId;
            this.Marks = Marks;
        }
        public void DisplayStudentDetails()
        {
            base.getDetails();
            Console.WriteLine("Student Id: "+this.studentId);
            Console.WriteLine("Student Marks: "+this.Marks);
        }
    }
}
