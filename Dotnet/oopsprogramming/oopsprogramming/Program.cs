namespace oopsprogramming
{
    class Program
    {
        class Age
        {
            private readonly int _year;
            private int year;

            public Age(int year)
            {
                this._year = year;
            }

            public void getAge()
            {
                Console.WriteLine(this._year);

            }

        }
        
        private static void Main(string[] args)
        {

            Mathoperations m1;
            Console.WriteLine("Enter the 1st Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number:");
            int num2 = int.Parse(Console.ReadLine());
            m1 = new Mathoperations(num1, num2);
            m1.Displayoperations();
            //User u1;
            //for(int i=0;i<3;i++)
            //{
            //    Console.WriteLine("Enter the Username:");
            //    string uname = Console.ReadLine();
            //    Console.WriteLine("Enter the Password:");
            //    string upass = Console.ReadLine();
            //    u1 = new User(uname, upass);
            //    string result = u1.CheckLogin();
            //    Console.WriteLine(result);
            //}

            //Age a = new Age(1990);
            //a.getAge();
            //Student s1, s2;
            //s1=new Student();
            //s2=new Student();

            //Student.collegename = "Sairam Institute of Technology";

            //s1.studentId = 1;
            //s1.studentname = "Nirmal Raj";
            //s1.marks = 100;

            //s2.studentId = 2;
            //s2.studentname = "Sandhya";
            //s2.marks = 90;

            //Console.WriteLine("Student Details");
            //Console.WriteLine("***********Student 1**********");
            //Console.WriteLine("College Name: "+Student.collegename);
            //Console.WriteLine("Student Id: "+s1.studentId);
            //Console.WriteLine("Student Name: " + s1.studentname);
            //Console.WriteLine("Student Mark: " + s1.marks);

            //Console.WriteLine("***********Student 2**********");
            //Console.WriteLine("College Name: " + Student.collegename);
            //Console.WriteLine("Student Id: " + s2.studentId);
            //Console.WriteLine("Student Name: " + s2.studentname);
            //Console.WriteLine("Student Mark: " + s2.marks);
            //Console.WriteLine();
            //Employee e1, e2;
            //e1 = new Employee();
            //e2 = new Employee();

            //Employee.companyname = "Chagepond Technologies";

            //e1.empname = "Nirmal Raj";
            //e1.age = 24;
            //e1.salary = 20000;

            //e2.empname = "Ikfan";
            //e2.age = 23;
            //e2.salary = 20000;
            //Console.WriteLine("Employee Details");
            //Console.WriteLine("----------Employee 1----------");
            //Console.WriteLine("Company Name: "+Employee.companyname);
            //Console.WriteLine("Employee Name: "+e1.empname);
            //Console.WriteLine("Employee Age: "+e1.age);
            //Console.WriteLine("Employee Salary: "+e1.salary);

            //Console.WriteLine("----------Employee 2----------");
            //Console.WriteLine("Company Name: " + Employee.companyname);
            //Console.WriteLine("Employee Name: " + e2.empname);
            //Console.WriteLine("Employee Age: " + e2.age);
            //Console.WriteLine("Employee Salary: " + e2.salary);
        }
    }
}