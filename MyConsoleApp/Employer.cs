using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyConsoleApp
{
    public class Employer
    {
        public bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }

            if (n == 2 || n == 3)
            {
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            for (var i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 1) == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public int MaximalSequence(int length)
        {
            int[] myArray = new int[length];
            int count = 1;
            int maxCount = 1;
            int maxElement = 0;

            for (int i = 0; i < length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                if (myArray[i] == myArray[i + 1])
                {
                    count++;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxElement = myArray[i];
                    count = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                return maxElement;
            }
            return count;
        }


        //Exercise 5
        //Write a program, which finds the maximal sequence of consecutively placed increasing integers.Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
        //public int IncreasingIntegers(int length)
        //{
        //    int[] myArray = new int[length];
        //    int count = 1;
        //    int maxCount = 1;
        //    int endIndex = 0;
        //    Console.WriteLine("Enter element of the array: ");
        //    for (int i = 0; i < length; i++)
        //    {
        //        myArray[i] = int.Parse(Console.ReadLine());
        //    }

        //    for (int i = 0; i < length - 1; i++)
        //    {
        //        if (myArray[i] < myArray[i + 1])
        //        {
        //            count++;
        //        }

        //        if (count > maxCount)
        //        {
        //            maxCount = count;
        //            endIndex = i;
        //            //int[] maxArray = new int[maxCount];
        //            //maxArray[i] = myArray[i];
        //        }
        //        else
        //        {
        //            count = 1;
        //        }
        //    }

        //    for (int i = endIndex - maxCount + 1; i <= endIndex; i++)
        //    {
        //        return myArray[i];
        //    }
        //    return count;
        //}


        //Exercise 6
        //Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. It is not necessary the elements to be consecutively placed.E.g.: { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
        public int MaximalSequenceIncreasingEven(int length)
        {
            int[] myArray = new int[length];
            int count = 1;
            int maxCount = 1;
            Console.WriteLine($"Enter ceil of element of an array: ");
            for (int i = 0; i < length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                if (myArray[i] < myArray[i + 1])
                {
                    if (myArray[i] % 2 == 0 && myArray[i + 1] % 2 == 0)
                    {
                        count++;
                    }
                }
                if (myArray[i] < myArray[i + 2])
                {
                    if (myArray[i] % 2 == 0 && myArray[i + 2] % 2 == 0)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    //int[] result = new int[maxCount];
                    //result[i] = myArray[i];
                    //return result[i];
                }
                else
                {
                    count = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                return maxCount;
            }
            return maxCount;
        }

        public string TotalAmountOfBooks(decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (var price in prices)
            {
                totalAmount += price;
            }
            string result = $"The total price of books is: {totalAmount}";
            return result;
        }


        public string PrintSign(int number)
        {
            if (number > 0)
            {
                return $"{number} is a positive number.";
            }
            else if (number < 0)
            {
                return $"{number} is a negative number.";
            }
            else
            {
                return $"{number} is zero number.";
            }
        }

        public string PrintMaxNumber(int num1, int num2)
        {
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            else
            {
                return "They are equal";
            }
            return $"The maximum number is: {max}";
        }

        public string PrintMaximumNumber(int num1, int num2)
        {
            if (num1 > num2)
            {
                return $"Num1 is the max number: {num1}";
            }
            else if (num2 > num1)
            {
                return $"Num2 is the max number: {num2}";
            }
            else
            {
                return "They are equal numbers.";
            }
        }


        public string PrintMaxOfNumbers(int num1, int num2)
        {
            int result = Math.Max(num1, num2);
            return $"The max number is {result}";
        }


        public void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine("I am {0}, {1} year(s) old. ", name, age);
        }

        public void PrintNumber(float number)
        {
            Console.WriteLine(number);
        }


        public int CalSum(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }


        public decimal SumTotalPriceOfBooks(params decimal[] prices)
        {
            decimal sum = 0;
            foreach (decimal price in prices)
            {
                sum += price;
            }
            return sum;
        }


        public void SomeMethod(string greetings, string name)
        {
            Console.WriteLine($"Greetings: {greetings}, Name: {name}");
        }

        public void SomeMethod(string greetings, string name, string ask)
        {
            Console.WriteLine($"Greetings: {greetings}, Name: {name}, Ask: {ask}!");
        }

        public void SomeMethod(int param1, float param2)
        {
            Console.WriteLine($" Name: {param1}, Ask: {param2}!");
        }

        public void SomeMethod(float p1, int p2)
        {
            Console.WriteLine($"Greetings: !");
        }


        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


        public decimal Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }


        public void PositiveNumber(int number)
        {
            if (number <= 0)
            {
                return;
            }
            Console.WriteLine(number);
        }


        public int GetTwoNumbers(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (b > a)
            {
                return - 1;
            }
            return 0;
        }

        //°C = (°F - 32) * 5 / 9,
        public decimal FahrenheitToCelsius(decimal temperatureInFahrenheit)
        {
            decimal celsiusToFahrenheit = (temperatureInFahrenheit - 32) * (5 / 9);
            return celsiusToFahrenheit;
        }


        public string GetMonthName(int month)
        {
            string monthName;
            switch (month)
            {
                case 1:
                monthName = "January";
                break;

                case 2:
                monthName = "February";
                break;

                case 3:
                monthName = "March";
                break;

                case 4:
                monthName = "April";
                break;

                case 5:
                monthName = "May";
                break;

                case 6:
                monthName = "June";
                break;

                case 7:
                monthName = "July";
                break;

                case 8:
                monthName = "August";
                break;

                case 9:
                monthName = "September";
                break;

                case 10:
                monthName = "October";
                break;

                case 11:
                monthName = "November";
                break;

                case 12:
                monthName = "December";
                break;
                default:
                Console.WriteLine("Invalid month!");
                return null;
            }
            return monthName;
        }


        public void SetPeriod(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period < 0)
            {
                period = period + endMonth;
            }
            Console.WriteLine("There is {0} months period from {1} to {2}.", period, GetMonthName(startMonth), GetMonthName(endMonth));
        }


        public bool ValidateHours(int hours)
        {
            bool result = (hours >= 0) && (hours <= 24);
            return result;
        }

        public bool ValidateMinutes(int minutes)
        {
            bool result = (minutes >= 0) && (minutes <= 60);
            return result;
        }
        //10 3 5 -1 0 12 8

        public int[] Sort(params int[] myArray)
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            return myArray;
        }

        public void PrintNum(params int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0}", myArray[i]);
                if (i < (myArray.Length - 1))
                {
                    Console.Write(", ");
                }
            }

        }
    }
}
