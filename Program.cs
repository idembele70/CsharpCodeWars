using System;

namespace CsharpCodeWars
{
    class Program
    {
        static void Main(string[] args)=>System.Console.WriteLine(CenturyFromYear(1701));
       public static double CenturyFromYear(double year){
           return Math.Ceiling(year/100);
       }

    }
}
