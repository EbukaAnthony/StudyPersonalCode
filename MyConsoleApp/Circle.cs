using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Circle //: Shape
    {
        //public int Radius { get; set; } 

        //public Circle(int radius)
        //{
        //    Radius = radius;
        //}

        //public override double GetArea()
        //{
        //    return Math.PI * Radius * Radius;
        //}


        //public bool IsPrime(int n)
        //{
        //    if (n < 2)
        //    {
        //        return false;
        //    }

        //    if (n == 2 || n == 3)
        //    {
        //        return true;
        //    }

        //    if (n % 2 == 0 || n % 3 == 0)
        //    {
        //        return false;
        //    }

        //    for (int i = 5; i < n; i += 6)
        //    {
        //        if (n % i == 0 || n % (i + 1) == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //Prime numbers
        //Console.Write("Enter n value: ");
        //int n = int.Parse(Console.ReadLine());

        //Console.Write("Enter m value: ");
        //int m = int.Parse(Console.ReadLine());

        //for (int num = n; num <= m; num++)
        //{
        //    bool prime = true;
        //    int divider = 2;
        //    int maxDivider = (int)Math.Sqrt(num);
        //    while (prime && (divider <= maxDivider))
        //    {
        //        if (num % divider == 0)
        //        {
        //            prime = false;
        //            break;
        //        }
        //        divider++;
        //    }
        //    if (prime == false)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(num + " ");
        //}

        public void PrimeNumbers(int m, int n)
        {
            for (int i = n; i <= m; i++)
            {
                bool isPrime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(i);
                while (isPrime && (divider <= maxDivider))
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divider++;
                }
                if (isPrime == false)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }


        public long Factorial(int number)
        {
            long factorial = 1;
            while (true)
            {
                if (number <= 1)
                {
                    break;
                }
                factorial *= number;
                number--;
            }
            return factorial;
        }


        public void Prime(int m, int n)
        {
            for (int i = n; i <= m; ++i)
            {
                int divide = 2;
                bool isPrime = true;
                int maxDivide = (int)Math.Sqrt(i);
                while (isPrime && (divide <= maxDivide))
                {
                    if (i % divide == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divide++;
                }
                if (!isPrime)
                {
                    continue;
                }
                Console.WriteLine(i + " ");
            }
        }
    }
}
