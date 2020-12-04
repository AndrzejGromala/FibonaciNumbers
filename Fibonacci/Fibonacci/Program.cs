using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
   class Program
   {
      public static int Fibonacci(int n)
      {
         int a = 0;
         int b = 1;
         // In N steps compute Fibonacci sequence iteratively.
         for (int i = 0; i < n; i++)
         {
            int temp = a;
            a = b;
            b = temp + b;
         }
         return a;
      }
      static void Main(string[] args)
      {
            Console.WriteLine("Fibonaci Numbers:");
         for (int i = 0; i < 15; i++)
         {
            Console.Write(Fibonacci(i) + ", ");
         }

         Console.Read();
      }
   }
}
