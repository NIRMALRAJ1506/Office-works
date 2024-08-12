internal class Program
{
    private static void Main(string[] args)
    {
        string[] weekdays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        //Console.WriteLine(weekdays[1]);
        Console.WriteLine(weekdays.Length);
        /* for (int i = 0; i < weekdays.Length; i++)
         {
             Console.WriteLine(weekdays[i]);
         }
        */



        foreach (string day in weekdays)
        {
            Console.WriteLine(day);
        }


        /*Array.Sort(weekdays);
 
        Console.WriteLine("Sorted in Ascending");
 
        foreach (string day in weekdays )
        {
            Console.WriteLine(day);
        }
 
        Array.Reverse(weekdays);
 
        Console.WriteLine("Sorted in Descending ");
 
        foreach (string day in weekdays)
        {
            Console.WriteLine(day);
        }
        */
        int daypos = Array.IndexOf(weekdays, "Wed");

        Console.WriteLine("Wednesday is " + (daypos + 1) + " day of week ");

        Array.Clear(weekdays, 0, 2);

        weekdays[0] = "Sunday";
        Array.Resize(ref weekdays, 7);
        weekdays[6] = "Some Special Day";

        string[] weekdays_copy = new string[7];
        //weekdays.Append("independance day");
        weekdays.CopyTo(weekdays_copy, 0);

        foreach (string day in weekdays_copy)
        {
            Console.WriteLine(day);
        }


        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        Console.WriteLine(months.Length);
        foreach (string month in months)
        {
            Console.WriteLine(month);
        }

        //Array.Sort(months);
        //Console.WriteLine("Array after sorting:");
        //foreach (string month in months)
        //{
        //    Console.WriteLine(month);
        //}

        //Array.Reverse(months);
        //Console.WriteLine("Array after Reversing:");
        //foreach(string month in months)
        //{
        //    Console.WriteLine(month);
        //}

        int monpos = Array.IndexOf(months, "Jun");
        Console.WriteLine("June is the "+(monpos+1)+" month");

        Array.Clear(months, 0, 3);
        months[0] = "1st month";

        Array.Resize(ref months, 13);
        months[12] = "No Month Exists";


        string[] monthscopy = new string[13];
        //weekdays.Append("independance day");
        months.CopyTo(monthscopy, 0);

        foreach (string month in monthscopy)
        {
            Console.WriteLine(month);
        }

    }
}