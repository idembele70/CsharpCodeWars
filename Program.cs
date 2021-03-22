using System;

namespace CsharpCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(NoSpace());
        }
     static string NoSpace(string input="Hello world how are you today.")
     {
         return input.Replace(" ", "");
     }
    }
}
