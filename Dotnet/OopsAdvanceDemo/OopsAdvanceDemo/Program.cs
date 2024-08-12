using OopsAdvanceDemo;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //Student student = new Student("Nirmal","Raj","Male",1,100);

        //student.DisplayStudentDetails();
        //Console.WriteLine("\n");
        //Employee emp = new Employee("Nirmal", "Raj", "Male", 1, 1000000);

        //emp.DisplayEmployeeDetails();

        //BMW b = new BMW();
        //b.brand = "BMW";
        //b.model = "5-series";
        //b.specialfeatures = "Massage seats";
        //Console.WriteLine(b.getCarDetails());

        //Mercedes m=new Mercedes();
        //m.brand = "Mercedes";
        //m.model = "M-15";
        //m.mileage = 15;
        //Console.WriteLine(m.getCarDetails());

        Student student = new Student();
        student.firstName = "Nirmal Raj";
        student.lastName = "S";
        student.Gender = "Male";
        student.studentId = 1;
        student.Marks = 100;
        Console.WriteLine(student.getDetails());
        Console.WriteLine("\n");
        Employee emp = new Employee();
        emp.firstName = "Sandhya";
        emp.lastName = "Suresh";
        emp.Gender = "Female";
        emp.empId = 100;
        emp.salary = 10000000;
        Console.WriteLine(emp.getDetails());
    }
}