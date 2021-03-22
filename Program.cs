using System;

namespace CsharpCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(NoSpace());
        }
        static string NoSpace(string input = "Hello world how are you today.")
        {
            string inputNoSpace = "";
            char space = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == space)
                {
                    inputNoSpace += "";
                }
                else
                {
                    inputNoSpace += input[i];
                }
            }
            return inputNoSpace;
        }
    }
}
