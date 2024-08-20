public delegate void calloutmyname(string username);
class publisher
{
    public event calloutmyname callname;
    public void raiseEvent(string username)
    {
        callname(username);
    }
}
class subcriberDemo
{
    public void subcribedcallname(string username)
    {
        Console.WriteLine("Good Morning : "+username);
    }
    public void connect()
    {
        publisher p=new publisher();
        p.callname += subcribedcallname;
        p.raiseEvent("Nirmal Raj");
        p.raiseEvent("Sandhya");
    }
}

class DelegateDemo
{
    public void Add(int a,int b)
    {
        int c = a + b;
        Console.WriteLine("Addition of: "+a+"+"+b+" is "+c);
    }

    public void Sub(int a,int b)
    {
        int c = a - b;
        Console.WriteLine("Subtraction of: " + a + "-" + b + " is " + c);
    }

    public void Mul(int a,int b)
    {
        int c = a * b;
        Console.WriteLine("Multiplication of: " + a + "*" + b + " is " + c);
    }

    public void Div(int a,int b)
    {
        int c = a / b;
        Console.WriteLine("Division of: " + a + "/" + b + " is " + c);
    }
}
public delegate void numberoperations(int a,int b);


class Program
{
    private static void Main(string[] args)
    {

        subcriberDemo sc = new subcriberDemo();
        sc.connect();
        //numberoperations no;
        //DelegateDemo dd = new DelegateDemo();
        //no = dd.Add;
        //no += dd.Sub;
        //no += dd.Mul;
        //no += dd.Div;
        //no(20, 30);
    }
}