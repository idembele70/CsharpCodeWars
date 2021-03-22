using System;
using System.Text;

namespace CsharpCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Solution());
        }
       static String Solution(string str="wolrd")
       {
           string newStr = "";
           for (int i = str.Length - 1; i >= 0 ; i--)
           {
               newStr += str[i];
           }
           return newStr;
       }
    }
}
