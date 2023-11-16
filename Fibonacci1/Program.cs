using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Masukkan jumlah elemen dalam rangkaian Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rangkaian Fibonacci:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.ReadLine();
        }

        public static int Fibonacci(int n)
         //static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
