using InterfaceDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        //Company c=new Company();
        //c.Name = "ChangePond Technologies";
        //c.addressline1 = "SIPCOT,Siruseri";
        //c.city = "Chennai";
        //c.state = "Tamil Nadu";
        //c.postcode = 60073;
        //c.email = "contact@cp.com";
        //c.mobile = 987654321;
        //c.AddressDetails();
        //c.ContactDetails();

        //Employee e = new Employee();
        //e.EmpName = "Nirmal Raj S";
        //e.addressline1 = "SIPCOT,Siruseri";
        //e.city = "Chennai";
        //e.state = "Tamil Nadu";
        //e.postcode = 60073;
        //e.email = "contact@cp.com";
        //e.mobile = 987654321;
        //e.AddressDetails();
        //e.ContactDetails();

        //Shop s=new Shop();
        //s.shopName = "SNR Digital World";
        //s.pname = "Dell Inspiron";
        //s.pprice = 52000;
        //s.pcategory = "Laptop";
        //s.outname = "Digital Paradise";
        //s.outcity = "Chennai";
        //s.outlocation = "Near Changepond Technologies";
        //s.OutletDetails();
        //s.ProductDetails();

        IShape sh;
        sh = new Square();
        Console.WriteLine("Enter the side:");
        sh.side=int.Parse(Console.ReadLine());
        sh.Draw();

        sh = new Rectangle();
        Console.WriteLine("Enter the length:");
        sh.length=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the breadth:");
        sh.breadth=int.Parse(Console.ReadLine());
        sh.Draw();

    }
}