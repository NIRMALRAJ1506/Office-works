using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> shoplist = new List<string>() { "Bread 500", "Cake 600", "Jam 550" };

        Console.WriteLine("List of Items in the Menu:");
        foreach (string items in shoplist)
        {
            Console.WriteLine(items);
        }


        string choice = "Y";
        while (choice == "Y" || choice == "y")
        {
            Console.WriteLine("Enter the product to be added:");
            string product = Console.ReadLine();
            shoplist.Add(product);
            Console.WriteLine("Do You want To Add More?");
            choice = Console.ReadLine();
        }
        Console.WriteLine("Menu after adding new Items:");
        foreach (string items in shoplist)
        {
            Console.WriteLine(items);
        }

        
        string choice1 = "Y";
        while (choice1 == "Y" || choice1 == "y")
        {
            Console.WriteLine("Choose the Operation Which needs to be done \n1.Update \n2.Remove\n3.Display");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Enter the Postion of the Product that need to be updated:");
                int pos=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new Value:");
                string value=Console.ReadLine();
                shoplist.Insert(pos, value);
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter the Item that needs to be removed:");
                string remitem=Console.ReadLine();
                shoplist.Remove(remitem);
            }
            else if (option == 3)
            {
                Console.WriteLine("Final List Of Items:");
                foreach (string items in shoplist)
                {
                    Console.WriteLine(items);
                }
            }
            else 
            {
                Console.WriteLine("Invalid Option");
            }
            Console.WriteLine("Do You Want To Continue?");
            choice1 = Console.ReadLine();
        }
        
    }
}