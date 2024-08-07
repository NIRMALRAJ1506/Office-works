using System.ComponentModel;
class Student
{
    private int std_id;
    protected int yob;
    internal int age;
    protected internal string gender;
    public string fname;

    public string getDetails()
    {
        std_id = 1;//Private members is accesible in the same class only.
        yob = 2001;//protected members is accessible in the same class and child class.
        age = 21;//Internal is accessible in same file but not other file .
        gender = "male";
        fname = "siva";//public members is accessible in any class

        return "ID:" + std_id + "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname;
    }
}

class School : Student
{
    public string schoolName;
    public string getDetailsWithSchool()
    {

        yob = 2001;//protected members is accessible in the same class and child class.
        age = 21;
        gender = "male";
        fname = "siva";//public members is accessible in any class
        schoolName = "A.M.H.S.S";
        return "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname + "SCHOOL_NAME :" + schoolName;
    }

}
class Parent
{
    public string getStudentDetails()
    {
        Student student = new Student();
        student.fname = "Shiva";
        student.age = 21;
        student.gender = "Male";
        return "STUDENT_FNAME :" + student.fname + "STUDENT_AGE :" + student.age + "STUDENT_GENDER :" + student.gender;
    }
}

class Program
{
    private static void Main(string[] args)
    {


        Student student = new Student();
        string d1 = student.getDetails();
        Console.WriteLine(d1);
        School school = new School();
        string d2 = school.getDetailsWithSchool();
        Console.WriteLine(d2);
        Parent parent = new Parent();
        string d3 = parent.getStudentDetails();
        Console.WriteLine(d3);



        /*//Console.WriteLine("Hello, World!");
        //Console.ReadKey();
        //Console.Clear();
        //Console.WriteLine("Welcome to .Net Class");
        //Console.ReadKey();

        //int num = 10;
        //Console.WriteLine(num);

        sbyte a = 10;
        byte b = 20;
        short c = 30;
        ushort d = 40;
        int e = 50;
        uint f = 60;
        long g = 70;
        ulong h = 80;
        float i = 90.23F;
        double j = 100.234234;
        decimal k = 110.2342324M;

        int min = int.MinValue;
        int max = int.MaxValue;

        uint umin = uint.MinValue;
        uint umax = uint.MaxValue;

        char ch = 'A';
        //Console.WriteLine(ch);

        bool boo = true;
        Console.WriteLine(boo);

        string s = "I am Nirmal Raj";
        Console.WriteLine(s);
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //Console.WriteLine(d);
        //Console.WriteLine(e);
        //Console.WriteLine(f);
        //Console.WriteLine(g);
        //Console.WriteLine(h);
        //Console.WriteLine(i);
        //Console.WriteLine(j);
        //Console.WriteLine(k);
        //Console.WriteLine(min);
        //Console.WriteLine(max);
        //Console.WriteLine(umin);
        //Console.WriteLine(umax);*/

        //double num1=10,num2=20;
        //Console.WriteLine(num1+num2);
        //Console.WriteLine(num1-num2);
        //Console.WriteLine(num1*num2);
        //Console.WriteLine(num1/num2);
        //Console.WriteLine(num1%num2);

        //Console.WriteLine(num1 += num2);
        //Console.WriteLine(num1 -= num2);
        //Console.WriteLine(num1 *= num2);
        //Console.WriteLine(num1 /= num2);
        //Console.WriteLine(num1 %= num2);

        //int x = 10, y = 20, z = 10;
        //bool result1 = ((x==y) && (x==z));
        //Console.WriteLine(result1);
        //bool result2 = ((x == y) || (x == z));
        //Console.WriteLine(result2);
        //bool result3 = !result1;
        //Console.WriteLine(result3);

        //int n = 21;

        //if(n%2==0)
        //{
        //    Console.WriteLine("Even");
        //}
        //else
        //{
        //    Console.WriteLine("odd");
        //}

        //Console.WriteLine("Enter the Year That needs to be checked:");
        //int year=int.Parse(Console.ReadLine());
        //if((year%400==0)||(year%4==0 && year % 100 != 0))
        //{
        //    Console.WriteLine("Leap Year");
        //}
        //else
        //{
        //    Console.WriteLine("Not a Leap Year");
        //}

        //int marks = 76;
        //if (marks >= 75)
        //{
        //    Console.WriteLine("Distinction");
        //}
        //else if(marks>=60 && marks < 75)
        //{
        //    Console.WriteLine("First Class");
        //}
        //else if(marks>=50 && marks < 60)
        //{
        //    Console.WriteLine("Second Class");
        //}
        //else if(marks>=35 && marks < 50) 
        //{
        //    Console.WriteLine("Third Class");
        //}
        //else
        //{
        //    Console.WriteLine("Fail");
        //}


        //int a = 100;
        //int b = 200000;
        //int c = 30;
        //if(a>b && a > c)
        //{
        //    Console.WriteLine(a+" is the Greatest");
        //}
        //else if(b>a && b > c)
        //{
        //    Console.WriteLine(b+" is the Greatest");
        //}
        //else if(c>a && c>b)
        //{
        //    Console.WriteLine(c+" is the Greatest");
        //}

        //Console.WriteLine("Enter the Month:");
        //int month = int.Parse(Console.ReadLine());
        //switch (month)
        //{
        //    case 1:
        //        Console.WriteLine("January");
        //        break;
        //    case 2:
        //        Console.WriteLine("Febraury");
        //        break;
        //    case 3:
        //        Console.WriteLine("March");
        //        break;
        //    case 4:
        //        Console.WriteLine("April");
        //        break;
        //    case 5:
        //        Console.WriteLine("May");
        //        break;
        //    case 6:
        //        Console.WriteLine("June");
        //        break;
        //    case 7:
        //        Console.WriteLine("July");
        //        break;
        //    case 8:
        //        Console.WriteLine("August");
        //        break;
        //    case 9:
        //        Console.WriteLine("September");
        //        break;
        //    case 10:
        //        Console.WriteLine("October");
        //        break;
        //    case 11:
        //        Console.WriteLine("November");
        //        break;
        //    case 12:
        //        Console.WriteLine("December");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid Month");
        //        break;
        //}

        //int num = 6;
        //int fact = 1;
        //while (num > 1)
        //{
        //    fact *= num;
        //    num--;
        //}
        //Console.WriteLine("The factorial of 6 is "+fact);

        //int i = 1;
        //int sumofodds = 0;
        //do
        //{
        //    if (i % 2 == 1)
        //    {
        //        sumofodds += i;
        //    }
        //    i++;
        //}
        //while (i < 100);
        //Console.WriteLine("Sum of Odd numbers between 1 to 100 is "+sumofodds);

        //int sumofnum = 0;
        //for (int i = 0; i < 100; i++)
        //{
        //    if (i % 10 == 0)
        //    {
        //        sumofnum += i;
        //    }
        //}
        //Console.WriteLine(sumofnum);
        //int num1 = 6;
        //int fact = 1;
        //for (int i = num1; i > 1; i--)
        //{
        //    fact *= i;
        //}
        //Console.WriteLine(fact);


        //int num = 64351;
        //int sum = 0;
        //while (num > 0)
        //{
        //    int num1 = num % 10;
        //    num= num / 10;

        //    sum += num1;
        //}
        //Console.WriteLine("Sum of digits: "+sum);

        //int num = 11;
        //int count = 0;
        //if (num == 1)
        //{
        //    Console.WriteLine("Neither or Nor Prime Number");
        //}
        //else
        //{
        //    for (int i = 2; i <= num / 2; i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            count++;
        //        }

        //    }
        //    if (count > 2)
        //    {
        //        Console.WriteLine(num + "  is not Prime NUmber");
        //    }
        //    else
        //    {
        //        Console.WriteLine(num + "  is  Prime NUmber");
        //    }
        //}
    }



}