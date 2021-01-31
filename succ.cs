using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheExpertSystem
{
    /************************************
    Title: TheExpertSystem
    Application Type: Console
    Description: Calculates how long you've been alive
    Author: Chase
    Date Created: 9/15/2020
    Last Modified:9/19/2020
    ************************************/
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("What unit of time would you like your age to be formated in?");
            Console.WriteLine("Years");
            Console.WriteLine("Months");
            Console.WriteLine("Weeks");
            Console.WriteLine("Days");
            Console.WriteLine("Hours");
            Console.WriteLine("Minutes");
            Console.WriteLine("Seconds");
            Console.WriteLine("Exit");
            string result = Console.ReadLine().ToUpper();
            if (result == "YEARS")
            {
                Years();
                return true;
            }
            else if (result == "MONTHS")
            {
                Months();
                return true;
            }
            else if (result == "WEEKS")
            {
                Weeks();
                return true;
            }
            else if (result == "DAYS")
            {
                Days();
                return true;
            }
            else if (result == "HOURS")
            {
                Hours();
                return true;
            }
            else if (result == "MINUTES")
            {
                Minutes();
                return true;
            }
            else if (result == "SECONDS")
            {
                Seconds();
                return true;
            }
            else if (result == "EXIT")
            { 
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That's NOT one of the options!");
                Console.WriteLine("Press any key to go back to main menu.");
                Console.ReadKey();
                return true;
            }

        }
        private static bool Years()
        {
            string userYear;
            string userMonth;
            string userDay;
            int y;
            int m;
            int d;
            
            Console.Clear();
            Console.WriteLine("What is your birth year?");
            
            userYear = Console.ReadLine();
            y = Convert.ToInt16(userYear);

            Console.WriteLine("What is your birth month?");
            
            userMonth = Console.ReadLine();
            m = Convert.ToInt16(userMonth);

            Console.WriteLine("What is your birth day?");
            
            userDay = Console.ReadLine();
            d = Convert.ToInt16(userDay);

            DateTime userBirthday = new DateTime(y, m, d);
            TimeSpan userAge = DateTime.Now.Subtract(userBirthday);
            Console.WriteLine("You have been alive for " + userAge.TotalDays / 365 + " years.");

            Console.ReadKey();
            return true;


        }
        private static bool Months()
        {
            string userYear;
            string userMonth;
            string userDay;
            int y;
            int m;
            int d;
            
            Console.Clear();
            Console.WriteLine("What is your birth year?");

            userYear = Console.ReadLine();
            y = Convert.ToInt16(userYear);

            Console.WriteLine("What is your birth month?");

            userMonth = Console.ReadLine();
            m = Convert.ToInt16(userMonth);

            Console.WriteLine("What is your birth day?");

            userDay = Console.ReadLine();
            d = Convert.ToInt16(userDay);

            DateTime userBirthday = new DateTime(y, m, d);
            TimeSpan userAge = DateTime.Now.Subtract(userBirthday);
            Console.WriteLine("You have been alive for " + userAge.TotalDays / 365 * 12 + " months." );


            Console.ReadKey();
            return true;
        }
        private static bool Weeks()
        {
            string userYear;
            string userMonth;
            string userDay;
            int y;
            int m;
            int d;

            Console.Clear();
            Console.WriteLine("What is your birth year?");

            userYear = Console.ReadLine();
            y = Convert.ToInt16(userYear);

            Console.WriteLine("What is your birth month?");

            userMonth = Console.ReadLine();
            m = Convert.ToInt16(userMonth);

            Console.WriteLine("What is your birth day?");

            userDay = Console.ReadLine();
            d = Convert.ToInt16(userDay);

            DateTime userBirthday = new DateTime(y, m, d);
            TimeSpan userAge = DateTime.Now.Subtract(userBirthday);
            Console.WriteLine("You have been alive for " + userAge.TotalDays / 7 + " weeks");

            Console.ReadKey();
            return true;


        }
        private static bool Days()
        {
            string userYear;
            string userMonth;
            string userDay;
            int y;
            int m;
            int d;
            
            Console.Clear();
            Console.WriteLine("What is your birth year?");

            userYear = Console.ReadLine();
            y = Convert.ToInt16(userYear);

            Console.WriteLine("What is your birth month?");

            userMonth = Console.ReadLine();
            m = Convert.ToInt16(userMonth);

            Console.WriteLine("What is your birth day?");

            userDay = Console.ReadLine();
            d = Convert.ToInt16(userDay);

            DateTime userBirthday = new DateTime(y, m, d);
            TimeSpan userAge = DateTime.Now.Subtract(userBirthday);
            Console.WriteLine("You have been alive for " + userAge.TotalDays + " days.") ;


            Console.ReadKey();
            return true;
        }
        private static bool Hours()
        {
            string userYear;
            string userMonth;
            string userDay;
            int y;
            int m;
            int d;
            
            Console.Clear();
            Console.WriteLine("What is your birth year?");

            userYear = Console.ReadLine();
            y = Convert.ToInt16(userYear);

            Console.WriteLine("What is your birth month?");

            userMonth = Console.ReadLine();
            m = Convert.ToInt16(userMonth);

            Console.WriteLine("What is your birth day?");

            userDay = Console.ReadLine();
            d = Convert.ToInt16(userDay);

            DateTime userBirthday = new DateTime(y, m, d);
            TimeSpan userAge = DateTime.Now.Subtract(userBirthday);
            Console.WriteLine("You have been alive for " + userAge.TotalDays * 24 + " hours.");


            Console.ReadKey();
            return true;
        }
        private static bool Minutes()
        {
            string userYear;
            string userMonth;
            string userDay;
            int y;
            int m;
            int d;

            Console.Clear();
            Console.WriteLine("What is your birth year?");

            userYear = Console.ReadLine();
            y = Convert.ToInt16(userYear);

            Console.WriteLine("What is your birth month?");

            userMonth = Console.ReadLine();
            m = Convert.ToInt16(userMonth);

            Console.WriteLine("What is your birth day?");

            userDay = Console.ReadLine();
            d = Convert.ToInt16(userDay);

            DateTime userBirthday = new DateTime(y, m, d);
            TimeSpan userAge = DateTime.Now.Subtract(userBirthday);
            Console.WriteLine("You have been alive for " + userAge.TotalMinutes + " minutes");

            Console.ReadKey();
            return true;


        }
        private static bool Seconds()
        {
            string userYear;
            string userMonth;
            string userDay;
            int y;
            int m;
            int d;
            
            Console.Clear();
            Console.WriteLine("What is your birth year?");

            userYear = Console.ReadLine();
            y = Convert.ToInt16(userYear);

            Console.WriteLine("What is your birth month?");

            userMonth = Console.ReadLine();
            m = Convert.ToInt16(userMonth);

            Console.WriteLine("What is your birth day?");

            userDay = Console.ReadLine();
            d = Convert.ToInt16(userDay);

            DateTime userBirthday = new DateTime(y, m, d);
            TimeSpan userAge = DateTime.Now.Subtract(userBirthday);
            Console.WriteLine("You have been alive for " + userAge.TotalSeconds + " seconds.");


            Console.ReadKey();
            return true;
        }
    }
}
