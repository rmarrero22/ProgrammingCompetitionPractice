using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your X: ");
                int x = Int32.Parse(Console.ReadLine());

                Console.Write("Enter your Y: ");
                int y = Int32.Parse(Console.ReadLine());

                Console.Write("Enter your N: ");
                int n = Int32.Parse(Console.ReadLine());

                ArrayList numbersWithNDivisors = FindNDivisors(x, y, n);

                foreach (int number in numbersWithNDivisors)
                {
                    Console.Write(number + " ");
                }
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static ArrayList FindNDivisors(int x, int y, int n)
        {
            ArrayList numbers = new ArrayList();

            for (int i = x; i <= y; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        if (i * i == j)
                        {
                            count++;
                        }
                    }
                }
                if (count == n)
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }
    }
}
