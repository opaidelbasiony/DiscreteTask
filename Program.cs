using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perefect_num
{
    internal class Program
    {
        static bool isperefct (int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) sum = sum + 1;
            }
            if (sum == number) return true;
            return false;

        }
        static void Main(string[] args)
        {

            Console.WriteLine("please Enter the first number");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("please Enter the seconed number");
            int w = int.Parse(Console.ReadLine());

            for (int i = y; i <= w; i++)
            {
                if (isperefct(i)) Console.WriteLine("{0},", i);
            }
            Console.ReadKey();


        }

    }
}
