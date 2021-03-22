using System;
using System.Linq;

namespace CsharpCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(sumnation());
        }
     public  static int sumnation(int num=8)
       {
           int sum = 0 ;
           for (int i = 0; i <= num; i++)
           {
               sum +=i;
           }
           return sum;
       }
    }
}
