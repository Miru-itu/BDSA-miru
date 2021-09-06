using System;

namespace Week0
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input;
            try
            {
                input = Int32.Parse(Console.ReadLine()); 
                PrintYayOrNay(IsLeapYear(input));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Plz enter a simple integer :)");
                Main(new string[0]);
            }
            
        }


        public static bool IsLeapYear(int year)
        {
            if (year > 1581)
            {
                return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
            }
            else
            {
                Console
                    .WriteLine("This program only handles years after 1581, try again");
                int input = Int32.Parse(Console.ReadLine());
                return IsLeapYear(input);
            }
        }

        public static void PrintYayOrNay(bool IsLeapYear)
        {
            if (IsLeapYear)
            {
                Console.WriteLine("yay");
            }
            else
            {
                Console.WriteLine("nay");
            }
        }
    }
}
