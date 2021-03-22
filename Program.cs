using System;
using System.Text;

namespace CsharpCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(RepeatStr());
        }
        public static String RepeatStr(int n = 2, string s = "Helli")
        {
            return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
        }
    }
}
