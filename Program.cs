using System.Linq;

namespace CsharpCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(SquareSum(new int[] {1,2,2}));
        }
       public static int SquareSum(int[] n){
           double sum = 0;
           for (int i = 0; i < n.Length; i++)
           {
             sum+=  System.Math.Pow(n[i],2);
           }
           return (int)sum;
       }


    }
}
