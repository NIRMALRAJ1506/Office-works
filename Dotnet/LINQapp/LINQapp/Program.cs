using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //List<int> ints = new List<int>() { 10, 15, 32, 49, 25, 33, 22, 66, 89 };
        //List<int> evenlist = new List<int>();

        //evenlist=(from item in ints where (item%2==0) select item).ToList();

        //foreach (int i in evenlist)
        //{
        //    Console.WriteLine(i);
        //}


        List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese", "Jam" };
        Console.WriteLine("Enter the Product Name:");
        string pname = Console.ReadLine();
        List<string> values = new List<string>();
        values=(from item in products where (item==pname) select item).ToList();
        
        if (values.Count == 1)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Equals(pname))
                {
                    Console.WriteLine(pname+" Exixts in the List");
                }
            }
        }
        else
        {
            Console.WriteLine(pname+" does not exists in the list");
        }
        }
    }
