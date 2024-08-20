public class Address
{
    public class Contact
    {
        private string street = "Ambedkar Salai";
        public void getContact()
        {
            Console.WriteLine("Chennai-600129");
        }
    }
}


//public delegate void calloutmyname(int x, int y);
//class PublisherDemo
//{
//    public event calloutmyname incrementevent;
//    public int x = 0, y = 10;
//    public void increment()
//    {
//        x += 5;
//        y += 10;
//        incrementevent(x, y);
//    }
//}

//class SubscriberDemo
//{
//    public void doIncrement()
//    {
//        PublisherDemo demo = new PublisherDemo();
//        demo.incrementevent += (a, b) =>
//        {
//            int c = a + b;
//            Console.WriteLine("result after ato increment " + c);
//        };
//        demo.increment();

//    }
//}
class Program
{
    private static void Main(string[] args)
    {
        //SubscriberDemo sd = new SubscriberDemo();
        //sd.doIncrement();
        //var numbers = new int[] { 2, 3, 5, 7, 9, 5 };

        //var count = numbers.Count(x => x == 5);
        //Console.WriteLine(count);

        //List<int> numbers1 = new List<int> { 2, 7, 5, 8, 1, 6, 5, 8, 9, 1 };
        //int count1 = numbers1.Count(x => x == 5);
        //Console.WriteLine(count1);

        Address.Contact ac= new Address.Contact();
        ac.getContact();

    }
}