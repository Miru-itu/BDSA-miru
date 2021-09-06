using System;

namespace Week0
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());    
            PrintYayOrNay(IsLeapYear(input));
        }




        public static bool IsLeapYear(int year){
           return (year%4==0 && (year%100!=0 || year%400==0));
        }

        public static void PrintYayOrNay(bool IsLeapYear){
           if(IsLeapYear){
              Console.WriteLine("yay"); 
           } else {
               Console.WriteLine("nay"); 
           }
        }


    }
}
