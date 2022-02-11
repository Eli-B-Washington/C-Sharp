using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main()
        {
            GetUserNameAndLocation();
            Console.WriteLine();

            //string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            //04-21-2021
            DateTime dt = DateTime.Now;
            ChristmasCountdown(dt);
            Console.WriteLine();

            GlazerApp.RunExample();
            Console.WriteLine();
            Console.WriteLine("Press any key to terminate the program.");
            Console.ReadKey();


        }

        private static void GetUserNameAndLocation()
        {
            var person = new Person();
            Console.WriteLine("What is your name? ");
            person.name = Console.ReadLine();
            Console.WriteLine($"Hi {person.name} ! Where are you from?");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice.  Press any key to continue...");
            Console.ReadKey();

        }

        private static void ChristmasCountdown(DateTime dt)
        {

            DateTime dt2 = new DateTime(DateTime.Now.Year, 12, 25);
            var days = (dt2 - dt).Days;

            string date1 = DateTime.UtcNow.ToString("MM-dd-yyyy");

            Console.WriteLine($"Today's date is:  {date1}");
            Console.WriteLine($"There are { days} until Christmas");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    
}
