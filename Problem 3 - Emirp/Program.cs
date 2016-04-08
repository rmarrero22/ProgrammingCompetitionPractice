using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Emirp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your X: ");
                int x = Int32.Parse(Console.ReadLine().ToString());

                Console.Write("Enter your Y: ");
                int y = Int32.Parse(Console.ReadLine().ToString());

                for (int i = x; i <= y; i++)
                {
                    if (IsPrimeNumber(i) && IsPalindromePrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        static bool IsPrimeNumber(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            if (count > 2)
                return false;

            else
                return true;
        }

        static bool IsPalindromePrime(int number)
        {   
            string numberString = ((Int32)number).ToString();
            int numberLength = numberString.Length;

            ArrayList palindromeArray = new ArrayList();

            for (int i = 0; i < numberLength; i++)
            {
                palindromeArray.Add(numberString.Substring(numberString.Length - 1));
                numberString = numberString.Substring(0, numberString.Length - 1);
            }

            string t = "";

            foreach (string n in palindromeArray)
            {
                t += n;
            }

            int palindrome = Int32.Parse(t);
            return IsPrimeNumber(palindrome);
        }
    }
}
