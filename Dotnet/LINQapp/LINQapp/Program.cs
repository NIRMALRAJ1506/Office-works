using LINQapp;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> empdetails;

        empdetails = new Dictionary<int, string>();

        empdetails.Add(100, "Nirmal");

        empdetails.Add(102, "Raj");

        empdetails.Add(103, "Sandhya");

        string ename = empdetails[102];

        Console.WriteLine(ename);

        SortedList<string, int> Marks;

        Marks = new SortedList<string, int>();

        Marks.Add("Maths", 80);

        Marks.Add("Physics", 90);

        Marks.Add("English", 65);

        Marks.Add("Chemistry", 75);

        foreach (string key in Marks.Keys)

        {

            Console.WriteLine(Marks[key]);

        }
        Console.WriteLine(Marks.ContainsKey("Maths"));
        Marks.Remove("Maths");
        Console.WriteLine("Dictionary after removing a key");
        foreach (string key in Marks.Keys)
        {
            Console.WriteLine(Marks[key]);
        }
        Console.WriteLine("Enter the Value:");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine(Marks.ContainsValue(value));
        //Product p1, p2, p3;
        //p1 = new Product() { Id = 1, Name = "shirts", Price = 250 };
        //p2 = new Product() { Id = 2, Name = "Trousers", Price = 300 };
        //p3 = new Product() { Id = 3, Name = "T-Shirts", Price = 450 };

        //List<Product> cartlist = new List<Product>();
        //List<Product> products = new List<Product>() { p1,p2,p3 };
        //for(int i=0; i<products.Count; i++)
        //{
        //    Product product = products[i];
        //    if (product.Price >= 300)
        //    {
        //        cartlist.Add(product);
        //    }

        //}
        //for(int i=0;i<cartlist.Count; i++)
        //{
        //    Product product = cartlist[i];
        //    Console.WriteLine(product.Name+" "+product.Price);
        //}
        ////List<int> ints = new List<int>() { 10, 15, 32, 49, 25, 33, 22, 66, 89 };
        ////List<int> evenlist = new List<int>();

        ////evenlist=(from item in ints where (item%2==0) select item).ToList();

        ////foreach (int i in evenlist)
        ////{
        ////    Console.WriteLine(i);
        ////}


        //List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese", "Jam" };
        //Console.WriteLine("Enter the Product Name:");
        //string pname = Console.ReadLine();
        //List<string> values = new List<string>();
        //values=(from item in products where (item==pname) select item).ToList();

        //if (values.Count == 1)
        //{
        //    for (int i = 0; i < values.Count; i++)
        //    {
        //        if (values[i].Equals(pname))
        //        {
        //            Console.WriteLine(pname+" Exixts in the List");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine(pname+" does not exists in the list");
        //}
        //}

    }
}
