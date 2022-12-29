using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace prime_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower bound of the range:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper bound of the range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers in the range are:");
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;

                if (i == 2 || i == 3)
                {
                    Console.WriteLine(i);
                }
                else if (i == 1 || i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    for (int k = 3; k <= Math.Sqrt(i); k += 2)
                    {
                        if (i % k == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(i);
                    }
                }


            }
        }
    }
}    