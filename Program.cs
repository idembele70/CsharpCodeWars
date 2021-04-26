using System;

namespace CsharpCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(countSheep(new bool[] {false,false,true}));
        }
       static int countSheep(bool[] sheeps)
      {
          int compteur = 0;
          for (int i = 0; i < sheeps.Length; i++)
          {
              if (sheeps[i])
              {
                  compteur+=1;
              }
          }
          return compteur;
      }
      
         
    }
}
