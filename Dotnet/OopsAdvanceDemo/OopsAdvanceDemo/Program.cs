using OopsAdvanceDemo;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student("Nirmal","Raj","Male",1,100);
       
        student.DisplayStudentDetails();
        Console.WriteLine("\n");
        Employee emp = new Employee("Nirmal", "Raj", "Male", 1, 1000000);
       
        emp.DisplayEmployeeDetails();
    }
}