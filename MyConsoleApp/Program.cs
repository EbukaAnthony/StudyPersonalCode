// See https://aka.ms/new-console-template for more information
using MyConsoleApp;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System.Reflection;
using System.Text;
using System.Collections.Concurrent;
using static System.Net.WebRequestMethods;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.Write("Enter number terms: ");
        //int number = int.Parse(Console.ReadLine());
        //GenerateFibonacci(number);

        //static void GenerateFibonacci(int n)
        //{
        //    int a = 0;
        //    int b = 1;
        //    int c;

        //    Console.Write("Fibonacci Series: ");

        //    for (var i = 0; i < n; i++)
        //    {
        //        Console.Write(a + " ");
        //        c = a + b;
        //        a = b;
        //        b = c;
        //    }
        //    Console.WriteLine();
        //}

        //Console.WriteLine("Hello, World!");
        //int x = 4;
        //Console.WriteLine(x *= 2);

        //double half = 1 / 2d;
        //Console.WriteLine(half);

        //Write an expression that checks whether an integer is odd or even. 
        //Console.WriteLine("Enter a number:");
        //int num = int.Parse(Console.ReadLine());
        //if (num % 2 == 0)
        //{
        //    Console.WriteLine("Is even");
        //}
        //else
        //{
        //    Console.WriteLine("Is odd");
        //}

        //Write a Boolean expression that checks whether a given integer is 
        //divisible by both 5 and 7, without a remainder. 
        //int a = 5;
        //int b = 7;
        //if (a % 2 == 0 && b % 2 == 0)
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}

        //Write an expression that looks for a given integer if its third digit (right 
        //to left) is 7.
        //Console.WriteLine("Enter a number:");
        //int number = int.Parse(Console.ReadLine());
        //int secondNum = number / 100;
        //int thirdNum = secondNum % 10;
        //if (thirdNum == 7)
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}

        //Write an expression that calculates the area of a trapezoid by given 
        //sides a, b and height h. 
        //The formula for trapezoid surface is: S = (a + b) * h / 2.
        //int a = 5;
        //int b = 6;
        //int h = 3;
        //int s = (a + b) * h / 2;
        //Console.WriteLine(s);

        //Write a program that prints on the console the perimeter and the area 
        //of a rectangle by given side and height entered by the user.
        //Console.WriteLine("Enter L value:");
        //int lValue = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter W value:");
        //int wValue = int.Parse(Console.ReadLine());

        //double perimeter = (lValue + lValue + wValue + wValue);
        //double area = lValue * wValue;
        //Console.WriteLine("Perimeter of a rectangle {0}:" + perimeter);
        //Console.WriteLine("Area of a rectangle {0}:" +  area);

        //The gravitational field of the Moon is approximately 17% of that on the 
        //Earth.Write a program that calculates the weight of a man on the 
        //moon by a given weight on the Earth. 
        //Console.WriteLine("Enter the weight of a man on earth");
        //double weight = double.Parse(Console.ReadLine());

        //double gravitationalField = 0.17;
        //double weightOnMoon = gravitationalField * weight;

        //Console.WriteLine(weightOnMoon);

        //Conditional Statement (If)

        //Console.WriteLine("Enter two numbers. ");

        //Console.WriteLine("Enter first number. ");
        //int firstNumber = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter second number. ");
        //int secondNumber = int.Parse(Console.ReadLine());

        //int sum = firstNumber;
        //if (secondNumber > firstNumber)
        //{
        //    sum = secondNumber;
        //}
        //Console.WriteLine(sum);


        //int a = 6;
        //bool isGreater = a > 7;
        //if (isGreater)
        //{
        //    Console.WriteLine(" a is greater 7. ");
        //}
        //else
        //{
        //    Console.WriteLine("a is not greater than 7. ");
        //}

        //int a = 6;
        //int b = 5;
        //if (a == b)
        //{
        //    Console.WriteLine("a is equal to b");
        //}
        //else
        //{
        //    if (a > b)
        //    {
        //        Console.WriteLine("a is greater than b");
        //    }
        //    else
        //    {
        //        Console.WriteLine("b is greater than a");
        //    }
        //}


        //Write an if-statement that takes two integer variables and exchanges
        //their values if the first one is greater than the second one.
        //Console.WriteLine("Enter first number. ");
        //int firstNumber = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter second number. ");
        //int secondNumber  = int.Parse(Console.ReadLine());

        //int thirdNumber = 0;

        //if (firstNumber > secondNumber)
        //{
        //    thirdNumber = firstNumber;
        //    secondNumber = thirdNumber;
        //    Console.WriteLine(secondNumber);
        //}
        //else if (secondNumber > firstNumber)
        //{
        //    thirdNumber = secondNumber;
        //    firstNumber = thirdNumber;
        //    Console.WriteLine(firstNumber);
        //}
        //else
        //{
        //    Console.WriteLine("There are equals");
        //}


        //Write a program that shows the sign (+ or -) of the product of three real 
        //numbers, without calculating it. Use a sequence of if operators.
        //Console.WriteLine("Enter a. ");
        //int a = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter b. ");
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter c. ");
        //int c = int.Parse(Console.ReadLine());

        //if (a == 0 && b == 0 && c == 0)
        //{
        //    Console.WriteLine("0");
        //}
        //else
        //{
        //    if (a < 0 && b < 0 && c < 0)
        //    {
        //        Console.WriteLine("-");
        //    }
        //    else if ((a < 0 && b < 0 && c > 0) || (a < 0 && c < 0 && b > 0) || (b < 0 && c < 0 && a > 0))
        //    {
        //        Console.WriteLine("-");
        //    }
        //    if (a > 0 && b > 0 && c > 0)
        //    {
        //        Console.WriteLine("+");
        //    }
        //    else if ((a > 0 && b > 0 && c < 0) || (a > 0 && c > 0 && b < 0) || (c > 0 && b > 0 && a < 0))
        //    {
        //        Console.WriteLine("+");
        //    }
        //}

        //Console.WriteLine("Enter a. ");
        //int a = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter b. ");
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter c. ");
        //int c = int.Parse(Console.ReadLine());

        //if (a > b)
        //{
        //    if (a > c)
        //    {
        //        Console.WriteLine("a is greater at:" + a);
        //    }
        //}
        //if (b > a)
        //{
        //    if (b > c)
        //    {
        //        Console.WriteLine($"b is greater at:" + b);
        //    }
        //}
        //if (c > a)
        //{
        //    if (c > b)
        //    {
        //        Console.WriteLine("c is greater at:" + c);
        //    }
        //}

        //4
        //Console.WriteLine("Enter a. ");
        //int a = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter b. ");
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter c. ");
        //int c = int.Parse(Console.ReadLine());

        //if (a > b && a > c)
        //{
        //    if (b > c)
        //    {
        //        Console.WriteLine($"{a}, {b}, {c}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{a}, {c}, {b}");
        //    }
        //}
        //if (b > a && b > c)
        //{
        //    if (a > c)
        //    {
        //        Console.WriteLine($"{b}, {a}, {c}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{b}, {c}, {a}");
        //    }
        //}
        //if (c > a && c > b)
        //{
        //    if (a > b)
        //    {
        //        Console.WriteLine($"{c}, {a}, {b}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{c}, {b}, {a}");
        //    }
        //}


        //5
        //Console.WriteLine("Enter 0-9. ");
        //int a = int.Parse(Console.ReadLine());

        //switch (a)
        //{
        //	case 0:
        //	Console.WriteLine("Zero");
        //	break;
        //	case 1:
        //	Console.WriteLine("One");
        //	break;
        //	case 2:
        //	Console.WriteLine("Two");
        //	break;
        //	case 3:
        //	Console.WriteLine("Three");
        //	break;
        //    case 4:
        //    Console.WriteLine("Four");
        //    break;
        //    case 5:
        //    Console.WriteLine("Five");
        //    break;
        //    case 6:
        //    Console.WriteLine("Six");
        //    break;
        //    case 7:
        //    Console.WriteLine("Seven");
        //    break;
        //    case 8:
        //    Console.WriteLine("Eight");
        //    break;
        //    case 9:
        //    Console.WriteLine("Nine");
        //    break;
        //    default:
        //    Console.WriteLine("Wrong number.");
        //    break;
        //}


        //6
        //Console.WriteLine("Enter a. ");
        //int a = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter b. ");
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter c. ");
        //int c = int.Parse(Console.ReadLine());

        //double d = (b * b) - (4 * a * c);
        //double Root1 = 0;
        //double Root2a = 0;
        //double Root2b = 0;
        //if (d == 0)
        //{
        //    Root1 = (-b / (2 * a));
        //    Console.WriteLine(Root1);
        //}
        //else if (d > 0)
        //{
        //    Root2a = ((- b) - (Math.Sqrt(d))) / (2 * a);
        //    Root2b = ((- b) + (Math.Sqrt(d))) / (2 * a);
        //    Console.WriteLine(Root2a);
        //    Console.WriteLine(Root2b);
        //}
        //else
        //{
        //    Console.WriteLine("It has no real root");
        //}

        //7
        //Console.WriteLine("Enter a. ");
        //int a = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter b. ");
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter c. ");
        //int c = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter d. ");
        //int d = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter e. ");
        //int e = int.Parse(Console.ReadLine());

        //int greatest = a;
        //if (b > greatest)
        //{
        //    greatest = b;
        //}
        //if (c > greatest)
        //{
        //    greatest = c;
        //}
        //if (d > greatest)
        //{
        //    greatest = d;
        //}
        //if (e > greatest)
        //{
        //    greatest = e;
        //}
        //Console.WriteLine($"The greatest is: {greatest}");

        // 8
        //Console.WriteLine("Enter a for int, b for double and c for string.");
        //var choice = char.Parse(Console.ReadLine());
        //switch (choice)
        //{
        //    case 'a':
        //    case 'A':
        //    Console.WriteLine("Enter an integer value.");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine(a + 1);
        //    break;
        //    case 'b':
        //    case 'B':
        //    Console.WriteLine("Enter a double value.");
        //    double b = double.Parse(Console.ReadLine());
        //    Console.WriteLine(b + 1);
        //    break;
        //    case 'c':
        //    case 'C':
        //    Console.WriteLine("Enter a string value.");
        //    string value = Console.ReadLine();
        //    Console.WriteLine("*");
        //    break;
        //    default:
        //    Console.WriteLine("Invalid");
        //    break;
        //}



        // 9
        //Console.WriteLine("Enter a. ");
        //int a = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter b. ");
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter c. ");
        //int c = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter d. ");
        //int d = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter e. ");
        //int e = int.Parse(Console.ReadLine());

        //if (a + b == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {b}");
        //}
        //if (a + c == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {c}");
        //}
        //if (a + d == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {d}");
        //}
        //if (a + e == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {e}");
        //}
        //if (b + c == 0)
        //{
        //    Console.WriteLine($"Subset: {b}, {c}");
        //}
        //if (b + d == 0)
        //{
        //    Console.WriteLine($"Subset: {b}, {d}");
        //}
        //if (b + e == 0)
        //{
        //    Console.WriteLine($"Subset: {b}, {e}");
        //}
        //if (c + d == 0)
        //{
        //    Console.WriteLine($"Subset: {c}, {d}");
        //}
        //if (c + e == 0)
        //{
        //    Console.WriteLine($"Subset: {c}, {e}");
        //}
        //if (d + e == 0)
        //{
        //    Console.WriteLine($"Subset: {d}, {e}");
        //}
        //if (a + b + c == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {b}, {c}");
        //}
        //if (a + b + d == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {b}, {d}");
        //} 
        //if (a + b + e == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {b}, {e}");
        //}
        //if (a + c + d == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {c}, {d}");
        //}
        //if (a + c + e == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {c}, {e}");
        //}
        //if (a + d + e == 0)
        //{
        //    Console.WriteLine($"Subset: {a}, {d}, {d}");
        //}
        //if (b + c + d == 0)
        //{
        //    Console.WriteLine($"Subset: {b}, {c}, {d}");
        //}
        //if (b + c + e == 0)
        //{
        //    Console.WriteLine($"Subset: {b}, {c}, {e}");
        //}
        //if (b + d + e == 0)
        //{
        //    Console.WriteLine($"Subset: {b}, {d}, {e}");
        //}
        //if (c + d + e == 0)
        //{
        //    Console.WriteLine($"Subset: {c}, {d}, {e}");
        //}



        // 10
        //Console.Write("Enter a score of 1-9.");
        //int score = int.Parse(Console.ReadLine());

        //switch (score)
        //{
        //    case 1:
        //    Console.WriteLine(score * 10);
        //    break;
        //    case 2:
        //    Console.WriteLine(score * 10);
        //    break;
        //    case 3:
        //    Console.WriteLine(score * 10);
        //    break;
        //    case 4:
        //    Console.WriteLine(score * 100);
        //    break;
        //    case 5:
        //    Console.WriteLine(score * 100);
        //    break;
        //    case 6:
        //    Console.WriteLine(score * 100);
        //    break;
        //    case 7:
        //    Console.WriteLine(score * 1000);
        //    break;
        //    case 8:
        //    Console.WriteLine(score * 1000);
        //    break;
        //    case 9:
        //    Console.WriteLine(score * 1000);
        //    break;
        //    default:
        //    Console.WriteLine("Invalid.");
        //    break;
        //}


        // Loop
        //int counter = 0;
        //while (counter <= 9)
        //{
        //    Console.WriteLine(counter);
        //    counter++;
        //}


        //Console.Write("Enter N number.");
        //int n = int.Parse(Console.ReadLine());
        //int num = 1;
        //int sum = 1;
        //while (num < n)
        //{
        //    num++;
        //    sum += num;
        //    Console.WriteLine(num);
        //}
        //Console.WriteLine(sum);


        // Prime Number
        //Console.Write("Enter a positive number: ");
        //int num = int.Parse(Console.ReadLine());
        //int divider = 2;
        //int maxDivider = (int)Math.Sqrt(num);
        //bool prime = true;
        //while (prime && (divider <= maxDivider))
        //{
        //    if (num % divider == 0)
        //    {
        //        prime = false;
        //    }
        //    divider++;
        //}
        //Console.WriteLine("Prime? " + prime);


        // Factorial
        //int n = int.Parse(Console.ReadLine());
        //int factorial = 1;
        //while (true)
        //{
        //    if (n <= 1)
        //    {
        //        break;
        //    }
        //    factorial *= n;
        //    n--;
        //}
        //Console.WriteLine(factorial);


        //Do-while Loop
        //int n = int.Parse(Console.ReadLine());
        //int factorial = 1;
        //do
        //{
        //    if (n <= 1)
        //    {
        //        break;
        //    }
        //    factorial *= n;
        //    n--;
        //} while (true);
        //Console.WriteLine(factorial);


        // For Loop
        //for (int i = 0; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}


        //for (int i = 1, sum = 1; i <= 128; i = i * 2, sum += i)
        //{
        //    Console.WriteLine("i={0}, sum={1}", i, sum);
        //}



        //Console.Write("n = ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("m = ");
        //int m = int.Parse(Console.ReadLine());
        //decimal result = 1;
        //for (int i = 0; i < m; i++)
        //{
        //    result *= n;
        //}
        //Console.WriteLine("n^m = " + result);


        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;
        //for (int i = 1;  i <= n; i += 2)
        //{
        //    if (i % 7 == 0)
        //    {
        //        continue;
        //    }
        //    sum += i;
        //}
        //Console.WriteLine("Sum = " + sum);


        //int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
        //foreach (int i in numbers)
        //{
        //    Console.Write(" " + i);
        //}
        //Console.WriteLine();
        //string[] towns = { "London", "Paris", "Milan", "New York" };
        //foreach (string town in towns)
        //{
        //    Console.Write(" " + town);
        //}

        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}


        // Prime Nested Loop
        //Console.Write("Enter N.");
        //int n = int.Parse(Console.ReadLine());

        //Console.Write("Enter M.");
        //int m = int.Parse(Console.ReadLine());
        //for (int num = n; num <= m; num++)
        //{
        //    bool prime = true;
        //    int divider = 2;
        //    decimal maxDivider = (int)Math.Sqrt(num);

        //    while (divider <= maxDivider)
        //    {
        //        if (num % divider == 0)
        //        {
        //            prime = false;
        //            break;
        //        }
        //        divider++;
        //    }
        //    if (prime)
        //    {
        //        Console.Write(" " + num);
        //    }
        //}


        //for (int a = 1; a <= 9; a++)
        //{
        //    for (int b = 0; b <= 9; b++)
        //    {
        //        for (int c = 0; c <= 9; c++)
        //        {
        //            for (int d = 0; d <= 9; d++)
        //            {
        //                if ((a + b) == (c + d))
        //                {
        //                    Console.WriteLine(
        //                     " " + a + " " + b + " " + c + " " + d);
        //                }
        //            }
        //        }
        //    }
        //}



        //static bool IsPrime(int n)
        //{
        //    if (n < 2) return false;
        //    if (n == 2 || n == 3) return true;
        //    if (n % 2 == 0 || n % 3 == 0) return false;

        //    for (int i = 5; i * i <= n; i += 6)
        //    {
        //        if (n % i == 0 || n % (i + 2) == 0)
        //            return false;
        //    }
        //    return true;
        //}


        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine(IsPrime(num) ? "Prime" : "Not Prime");



        //static void GenerateFibonacci(int n)
        //{
        //    int a = 0, b = 1, temp;

        //    Console.Write("Fibonacci Series: ");

        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write(a + " ");
        //        temp = a + b;
        //        a = b;
        //        b = temp;
        //    }
        //    Console.WriteLine();
        //}

        //Console.Write("Enter number of terms: ");
        //int num = int.Parse(Console.ReadLine());
        //GenerateFibonacci(num);


        //static bool IsPrime(int num)
        //{
        //    if (num < 2)
        //    {
        //        return false;
        //    }
        //    if (num == 2 || num == 3)
        //    {
        //        return true;
        //    }
        //    if (num % 2 == 0 || num % 3 == 0)
        //    {
        //        return false;
        //    }
        //    for (var i = 5; i * i <= num; i =+ 6)
        //    {
        //        if (num % i == 0 || num % (i + 1) == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //Console.Write("Enter a number.");
        //int number = int.Parse(Console.ReadLine());

        //Console.WriteLine(IsPrime(number) ? "Prime" : "Not Prime");


        //static void GenerateFibonacci(int num)
        //{
        //    int a = 0;
        //    int b = 1;
        //    int c;

        //    Console.Write("Fibonacci Series.");

        //    for (var i = 0; i < num; i++)
        //    {
        //        Console.Write(a + " ");
        //        c = a + b;
        //        a = b;
        //        b = c;
        //    }
        //    Console.WriteLine();
        //}

        //Console.Write("Enter a number.");
        //int num = int.Parse(Console.ReadLine());
        //GenerateFibonacci(num);


        //static bool IsPrime(int n)
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

        //    for (var i = 5; i*i <= n; i += 6)
        //    {
        //        if (n % i == 0 || n % (i + 1) == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //Console.Write("Enter a number");
        //int number = int.Parse(Console.ReadLine());

        //Console.WriteLine(IsPrime(number) ? "Prime" : "Not Prime");



        //static void GenerateFibonacci(int n)
        //{
        //    int a = 0;
        //    int b = 1;
        //    int c;

        //    Console.Write("Fibonacci Series: ");

        //    for (var i = 0; i < n; i++)
        //    {
        //        Console.Write(a + " ");
        //        c = a + b;
        //        a = b; 
        //        b = c;
        //    }
        //    Console.WriteLine();
        //}

        //Console.Write("Enter number of terms: ");
        //int num = int.Parse(Console.ReadLine());
        //GenerateFibonacci(num);

        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine(number);


        //Console.Write("Enter number of terms: ");
        //int num = int.Parse(Console.ReadLine());
        //GenerateFibonacci(num);

        //static void GenerateFibonacci(int n)
        //{
        //    int a = 0;
        //    int b = 1;
        //    int c;
        //    Console.Write("Fibonacci Series: ");
        //    for (var i = 0; i < n; i++)
        //    {
        //        Console.Write(a + " ");
        //        c = a + b;
        //        a = b;
        //        b = c;
        //    }
        //    Console.WriteLine();
        //}



        //Console.Write("Enter a number");
        //int number = int.Parse(Console.ReadLine());

        //Console.WriteLine(IsPrime(number) ? "Prime" : "Not Prime");

        //static bool IsPrime(int num)
        //{
        //    if (num < 2)
        //    {
        //        return false;
        //    }
        //    if (num == 2 || num == 3)
        //    {
        //        return true;
        //    }
        //    if (num % 2 == 0 || num % 3 == 0)
        //    {
        //        return false;
        //    }

        //    for (var i = 5; i * i <= num; i += 6)
        //    {
        //        if (num % i == 0 || num % (i + 1) == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}


        //Console.Write("Enter number M: ");
        //int m = int.Parse(Console.ReadLine());

        //Console.Write("Enter number N: ");
        //int n = int.Parse(Console.ReadLine());

        //for (var num = n; num <= m; num++)
        //{
        //    int divider = 2;
        //    bool isPrime = true;
        //    int maxDivider = (int)Math.Sqrt(num);

        //    while (divider <= maxDivider)
        //    {
        //        if (num % divider == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //        divider++;
        //    }

        //    if (isPrime)
        //    {
        //        Console.Write(" " + num);
        //    }
        //}

        //int[] myArray = new int[6] { 0, 1, 2, 3, 4, 5 };
        //foreach (var item in myArray)
        //{
        //    Console.WriteLine(item);
        //}

        //Reverse Array
        //int[] array = {1, 2, 3, 4, 5};
        //int length = array.Length;
        //int[] reverse = new int[length];
        //for (int i = 0; i < length; i++)
        //{
        //    reverse[length - i - 1] = array[i];
        //}
        //for (int i = 0; i < length; i++)
        //{
        //    Console.Write(reverse[i] + " ");
        //}


        // Symmetric
        //Console.Write("Enter a positive integer: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];
        //Console.WriteLine("Enter the values of the array:");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //bool symmetric = true;
        //for (int i = 0; i < array.Length / 2; i++)
        //{
        //    if (array[i] != array[n - i - 1])
        //    {
        //        symmetric = false;
        //        break;
        //    }
        //}
        //Console.WriteLine("Is symmetric? {0}", symmetric);


        //string[] array = { "one", "two", "three", "four" };
        //for (int index = 0; index < array.Length; index++)
        //{
        //    // Print each element on a separate line
        //    Console.WriteLine("Element[{0}] = {1}", index, array[index]);
        //}


        //Double the element of the Array
        //int[] array = new int[] { 1, 2, 3, 4, 5 };
        //Console.Write("Output: ");
        //for (int index = 0; index < array.Length; index++)
        //{
        //    // Doubling the number
        //    array[index] = 2 * array[index];
        //    // Print the number
        //    Console.Write(array[index] + " ");
        //}



        // Declare and initialize a matrix of size 2 x 4
        //int[,] matrix =
        //{
        //    {1, 2, 3, 4}, // row 0 values
        //    {5, 6, 7, 8}, // row 1 value
        //};
        //// Print the matrix on the console
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write(matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}


        //Console.Write("Enter the number of the rows: ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Enter the number of the columns: ");
        //int cols = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[rows, cols];
        //Console.WriteLine("Enter the cells of the matrix:");
        //for (int row = 0; row < rows; row++)
        //{
        //    for (int col = 0; col < cols; col++)
        //    {
        //        Console.Write("matrix[{0},{1}] = ", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write(" " + matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}


        //var grade = 84;
        //int n = ((grade / 5) + 1) * 5;
        //Console.WriteLine(n);

        //static List<int> GradingStudents(List<int> grades)
        //{
        //    int n = 4;
        //    for (var i = n; i < length; i++)
        //    {

        //    }
        //}


        //static bool IsPrime(int n)
        //{
        //    if (n < 2) return false;
        //    if (n == 2 || n == 3) return true;
        //    if (n % 2 == 0 || n % 3 == 0) return false;

        //    for (int i = 5; i * i <= n; i += 6)
        //    {
        //        if (n % i == 0 || n % (i + 2) == 0)
        //            return false;
        //    }
        //    return true;
        //}


        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine(IsPrime(num) ? "Prime" : "Not Prime");



        //static void GenerateFibonacci(int n)
        //{
        //    int a = 0, b = 1, temp;

        //    Console.Write("Fibonacci Series: ");

        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write(a + " ");
        //        temp = a + b;
        //        a = b;
        //        b = temp;
        //    }
        //    Console.WriteLine();
        //}


        //Console.Write("Enter number of terms: ");
        //int num = int.Parse(Console.ReadLine());
        //GenerateFibonacci(num);


        //bool IsPrime(int n)
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
        //    for (int i = 5; i < n; i = +6)
        //    {
        //        if (n % i == 0 || n % (i + 2) == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}


        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine(IsPrime(number)? "IsPrime" : "Not Prime");


        //static void GenerateFibonacci(int n)
        //{
        //    int a = 0, b = 1, c = 0;
        //    Console.Write("Enter series: ");
        //    for (var i = 0; i < n; i++)
        //    {
        //        Console.Write(a + " ");
        //        c = a + b;
        //        a = b;
        //        b = c;
        //    }
        //    Console.WriteLine();
        //}

        //Console.Write("Enter a number: ");
        //int result = int.Parse(Console.ReadLine());
        //GenerateFibonacci(result);


        //static bool IsPrime(int m)
        //{
        //    if (m < 2)
        //    {
        //        return false;
        //    }
        //    if (m == 2 || m == 3)
        //    {
        //        return true;
        //    }
        //    if (m % 2 == 0 || m % 3 == 0)
        //    {
        //        return false;
        //    }
        //    for (var i = 5; i < m; i += 6)
        //    {
        //        if (m % i == 0 || m % (i + 2) == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine(IsPrime(number) ? "Prime" : "Not Prime");


        //
        //int a = 1;
        //int b = 2;
        //bool greaterAB = (a > b);
        //bool equalA1 = (a == 1);
        //if (greaterAB)
        //{
        //    Console.WriteLine("A > B");
        //}
        //else
        //{
        //    Console.WriteLine(" B > A");
        //}
        //Console.WriteLine("greaterAB = " + greaterAB);
        //Console.WriteLine("equalA1 = " + equalA1);


        //Special characters
        //char character = 'a';
        //Console.WriteLine(character);

        //character = '\u003A';
        //Console.WriteLine(character);

        //character = '\'';
        //Console.WriteLine(character);

        //character = '\\';
        //Console.WriteLine(character);

        //int a = 5;
        //int b = 4;
        //Console.WriteLine(a + b); // 9
        //Console.WriteLine(a + (b++)); // 9
        //Console.WriteLine(a + b); // 10
        //Console.WriteLine(a + (++b)); // 11
        //Console.WriteLine(a + b); // 11
        //Console.WriteLine(14 / a); // 2
        //Console.WriteLine(14 % a); // 4

        //int one = 1;
        //int zero = 0;
        // Console.WriteLine(one / zero); // DivideByZeroException

        //double dMinusOne = -1.0;
        //double dZero = 0.0;
        //Console.WriteLine(dMinusOne / zero); // -Infinity
        //Console.WriteLine(one / dZero); // Infinity

        //int a = 10;
        //int b = 5;
        //Console.WriteLine("a == b:" + (a != b));

        //int a, b, c;
        //a = b = c = 25;
        //Console.WriteLine("{0} {0} {0}", a,b,c);

        //int x = 6;
        //int y = 7;  
        //int result = (y != x)? y : x;
        //Console.WriteLine(result);

        //Tenary operator
        //int a = 10; int b = 20;
        //Console.WriteLine((a - b == -10 && a + b == 30) ? "True" : "False");

        //Console.Write("Enter first number: ");
        //int firstNumber = int.Parse(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //int secondNumber = int.Parse(Console.ReadLine());
        //Console.WriteLine(firstNumber == secondNumber ? "True" : "False");

        //
        //string value = null;
        //Console.WriteLine(value ?? "false");

        //double num = 5.1d;
        //Console.WriteLine(num);
        //int a = 0;
        //a = (int)num;
        //Console.WriteLine(a);
        //decimal b = a + (decimal)num;
        //Console.WriteLine(b);
        //long l = (long)num;
        //Console.WriteLine(l);
        //float f = (float)b;
        //Console.WriteLine(f);

        //int myInt = int.MaxValue;
        //Console.WriteLine(myInt);
        //float myFloat = float.MaxValue;
        //Console.WriteLine(myFloat);
        //long myLong = long.MaxValue;
        //Console.WriteLine(myLong);
        //double myDouble = double.MaxValue;
        //Console.WriteLine(myDouble);
        //decimal myDecimal = decimal.MaxValue;
        //Console.WriteLine(myDecimal);

        //double d = 5.1d;
        //int b = checked((int)d);
        //Console.WriteLine(b);

        //int a = 3;
        //string b = a.ToString();
        //Console.WriteLine(b);

        //double b = (double)1 / 2;
        //Console.WriteLine(b);
        // Or
        //double a = 1 / 2d;
        //Console.WriteLine(a);

        //int a = 1;
        //double b = 0.0;
        //int c = (int)b;
        //Console.WriteLine(a / b);
        //Console.WriteLine(b / b);
        //Console.WriteLine(c / c);

        //double a = ((double)(1 + 2)) / 4;
        //Console.WriteLine(a);

        //Console.WriteLine("2 + 3 = " + 2 + 3);
        //Console.WriteLine(("2 + 3 = " + (2 + 3)));

        //Even or Odd
        //Using Tenary Operator
        //Console.Write("Enter firstNumber: ");
        //int firstNumber = int.Parse(Console.ReadLine());
        //Console.Write("Enter secondNumber: ");
        //int secondNumber = int.Parse(Console.ReadLine());
        //string result = firstNumber % secondNumber == 0 ? "Even" : "Odd";
        //Console.Write(result);

        // Or
        // If Statement
        //Console.Write("Enter firstNumber: ");
        //int firstNumber = int.Parse(Console.ReadLine());

        //Console.Write("Enter secondNumber: ");
        //int secondNumber = int.Parse(Console.ReadLine());

        //if (firstNumber % secondNumber == 0)
        //{
        //    Console.Write("Is an Even number" );
        //}
        //else
        //{
        //    Console.WriteLine("Is an Odd number.");
        //}


        // Divisible by 5 and 7 without a remainder
        //Tenary Operator
        //Console.Write("Enter firstNumber: ");
        //int firstNumber = int.Parse(Console.ReadLine());

        //bool isDivisible = (firstNumber % 5 == 0) && (firstNumber % 7 == 0) ? true : false;
        //Console.Write(isDivisible);


        //if statement
        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //bool isDivisible = (num % 5 == 0) && (num % 7 == 0);
        //if (isDivisible)
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}

        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //int thirdNumber = (num / 100);
        //int result = thirdNumber % 10;
        //if (result == 7)
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}


        //Area of a Trapezoid S = (a + b) * h / 2.
        //Console.Write("Enter value A: ");
        //int aValue = int.Parse(Console.ReadLine());
        //Console.Write("Enter value B: ");
        //int bValue = int.Parse(Console.ReadLine());
        //Console.Write("Enter value H: ");
        //int hValue = int.Parse(Console.ReadLine());
        //decimal s = (decimal)(aValue + bValue) * (hValue / 2);
        //Console.WriteLine("Area of a Trapezoid is = " + s);


        //Perimeter and Area of a Rectangle
        //Console.Write("Enter the value of B: ");
        //double bValue = double.Parse(Console.ReadLine());
        //Console.Write("Enter the value of H: ");
        //double hValue = double.Parse(Console.ReadLine());
        //double areaOfARectangle = (bValue * hValue);
        //double perimeterOfARectangle = (2 * bValue) + (2 * hValue);
        //Console.WriteLine("Area of a Rectangle = " + areaOfARectangle);
        //Console.WriteLine("Perimeter of a Rectangle = " + perimeterOfARectangle);

        //Console.Write("Enter your weight on Earth (in Kg): ");
        //if (double.TryParse(Console.ReadLine(), out double earthWeight))
        //{
        //    double moonWeight = (earthWeight * 0.17);
        //    Console.WriteLine("Weight of a man on moon is = " + moonWeight);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input");
        //}

        //static void GenerateFibonacci(int n)
        //{
        //    int a = 0, b = 1, c;
        //    Console.Write("Fibonacci series: ");
        //    for (var i = 0; i < n; i++)
        //    {
        //        Console.Write(a + " ");
        //        c = a + b;
        //        a = b;
        //        b = c;
        //    }
        //    Console.WriteLine();
        //}

        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //GenerateFibonacci(num);

        //static bool IsPrime(int n)
        //{
        //    if (n < 2)
        //        return false;
        //    if (n ==2 || n == 3)
        //        return true;
        //    if (n % 2 == 0 || n % 3 == 0)
        //        return false;
        //    for (var i = 5; i * i <= n; i += 6)
        //    {
        //        if (n % i == 0 || n % (i + 2) == 0)
        //        {
        //            return false;
        //        }            
        //    }
        //    return true;
        //}

        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine(IsPrime(number) ? "IsPrime" : "Not Prime");


        //Console.WriteLine("Hello World");
        //Console.WriteLine(5);
        //Console.WriteLine(Math.PI);
        //Console.Write("Hello World");
        //Console.Write(5);
        //Console.Write(Math.PI);


        //Concatenation of strings
        //int age = 26;
        //Console.WriteLine("He is " + age + " years old.");

        //string s = "Four: " + 2 + 2;
        //Console.WriteLine(s);
        //string s2 = "Four: " + (2 + 2);
        //Console.WriteLine(s2);


        //Formatted String
        //string str = "Hello World!";
        //Normal Way
        //Console.Write(str);
        //Formatting String
        //Console.Write("{0}", str);


        //string name = "John";
        //int age = 20;
        //string town = "Asaba";
        //Console.Write("{0} is {1} years old from {2}!\r\n", name, age, town);

        //int codeRead = 0;
        //do
        //{
        //    codeRead = Console.Read();
        //    if (codeRead != 0)
        //    {
        //        Console.WriteLine((char)codeRead);
        //    }
        //}
        //while(codeRead != 10);

        //TryParse
        //string str = Console.ReadLine();
        //int intValue;
        //bool parseSuccess = Int32.TryParse(str, out intValue);
        //Console.WriteLine(parseSuccess ?"The square of the number is " + intValue * intValue + ".": "Invalid number!");


        //Console.Write("Enter a value: ");
        //string strValue = Console.ReadLine();
        //bool isSuccessful = int.TryParse(strValue, out int result);
        //if (isSuccessful)
        //{
        //    Console.WriteLine(result);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid number.");
        //}

        //int number;
        //int count = 0;
        //bool isValid = false;
        //while (count < 3)
        //{
        //    Console.Write("Enter a valid number: ");
        //    string input = Console.ReadLine();
        //    if (int.TryParse(input, out number))
        //    {
        //        Console.WriteLine($"You have entered a valid number: {number}");
        //        isValid = true;
        //        break;
        //    }
        //    else
        //    {
        //        count++;
        //        if (count < 3)
        //        {
        //            Console.WriteLine("Invalid input, Please try again.");
        //        }
        //    }
        //}
        //if (!isValid)
        //{
        //    Console.WriteLine("You have exceeded the number of attempts. You are advice to stop.");
        //}


        //int num;
        //int count = 0;
        //bool isValid = false;
        //while (count < 3)
        //{
        //    Console.Write("Enter a valid number: ");
        //    string input = Console.ReadLine();
        //    bool successfulInput = int.TryParse(input, out num);
        //    if (successfulInput)
        //    {
        //        Console.WriteLine("You have entered a valid number.");
        //        isValid = true;
        //        break;
        //    }
        //    else
        //    {
        //        count++;
        //        if (count < 3)
        //        {
        //            Console.WriteLine("Invalid number, please try again.");
        //        }
        //    }
        //}
        //if (count == 3)
        //{
        //    Console.WriteLine("You have exceeded your attempts.");
        //}


        //ConsoleKeyInfo key = Console.ReadKey();
        //Console.WriteLine();
        //Console.WriteLine("Character entered: " + key.KeyChar);
        //Console.WriteLine("Special keys: " + key.Modifiers);


        //Console.Write("This program calculates the Area of a rectangle or a triangle.");
        //Console.Write("Enter a and b (for rectangle) " + " or a and h (for triangle): ");
        //string aInput = Console.ReadLine();
        //string bInput = Console.ReadLine();
        //bool isAValid = int.TryParse(aInput, out int aValue);
        //bool isBValid = int.TryParse(bInput, out int bValue);
        //if (isAValid && isBValid)
        //{
        //    Console.WriteLine("Enter 1 for a rectangle or " + " 2 for a triangle: ");
        //    string choice = Console.ReadLine();
        //    bool validChoice = int.TryParse(choice, out int choiceValue);
        //    if (validChoice)
        //    {
        //        double area = (double)(aValue * bValue) / choiceValue;
        //        Console.WriteLine("The area of your value is: " + area);  
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid choice value");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid a value and b value");
        //}


        //Chapter 4
        //Exercise 1
        //Sum of Three (3) numbers;
        //Console.Write("Enter first number: ");
        //string aInput = Console.ReadLine();

        //Console.Write("Enter second number: ");
        //string bInput = Console.ReadLine();

        //Console.Write("Enter third number: ");
        //string cInput = Console.ReadLine();

        //bool validA = int.TryParse(aInput, out int aValue);
        //bool validB = int.TryParse(bInput, out int bValue);
        //bool validC = int.TryParse(cInput, out int cValue);

        //if (validA && validB && validC)
        //{
        //    var sum = (aValue + bValue + cValue);
        //    Console.WriteLine(sum);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input.");
        //}


        //Exercise 2
        //The Perimeter and Area of a Circle(Area(A = pir
        //Console.Write("Enter the radius of a circle: ");
        //string radiusInput = Console.ReadLine();
        //bool validRadius = int.TryParse(radiusInput, out int radius);
        //if (validRadius)
        //{
        //    double perimeterOfACircle = (double)(2 * Math.PI * radius);
        //    double areaOfACircle = (double)((Math.PI) * (Math.Pow(radius,2)));
        //    double area = (double)(Math.PI * radius * radius);
        //    Console.WriteLine($"Perimeter of a circle is: {perimeterOfACircle}");
        //    Console.WriteLine($"Area of a circle is: {areaOfACircle}"); 
        //    Console.WriteLine(area);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input");
        //}

        //Exercise 3
        //A given company has name, address, phone number, fax number, web site and manager.The manager has name, surname and phone number.
        //Write a program that reads information about the company and its manager and then prints it on the console.
        //Console.WriteLine("Information about the Company and its Manager");
        //string companyName = "Crowny Hotel And Suits";
        //string companyAddress = "No 17 Barnawa road Kaduna";
        //string companyPhoneNumber = "09048448280";
        //string companyFaxNumber = "+1234567890";
        //string companyWebSite = "http//:www.crownyhotelandsuits.com";
        //string managerName = "Vanessa";
        //string managerSurName = "Montego";
        //string managerPhoneNumber = "08161778965";
        //Console.WriteLine($"The name of my company is {companyName}, is located at {companyAddress}, the phone number of my company is {companyPhoneNumber}, the company fax number is {companyFaxNumber}, the website of the company is {companyWebSite} and the manager's name is {managerName} {managerSurName} with her phone number which is {managerPhoneNumber}");


        //Exercise 4
        //int number1 = 10;         // example integer
        //double number2 = 12.3456; // example positive float
        //double number3 = -7.6;    // example negative float

        //Console.WriteLine("{0,-10}{1,-10:F2}{2,-10:F2}", number1.ToString("X"), number2, number3);


        //Exercise 5
        //Console.Write("Enter first number: ");
        //int a = int.Parse(Console.ReadLine());
        //Console.Write("Enter second number: ");
        //int b = int.Parse(Console.ReadLine());
        //if (a < b)
        //{
        //    for (int i = a; i <= b; i++)
        //    {
        //        if (i % 5 == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("First number must be less than second number.");
        //}


        //Exercise 6
        //Write a program that reads two numbers from the console and prints the greater of them.Solve the problem without using conditional statements.
        //Console.Write("Enter first number: ");
        //int a = int.Parse(Console.ReadLine());
        //Console.Write("Enter second number: ");
        //int b = int.Parse(Console.ReadLine());
        //int greater = Math.Max(a, b);
        //int great = a > b ? a : b;
        //Console.WriteLine(greater);
        //Console.WriteLine(great);


        //Exercise 7
        //Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user
        //to enter another number.

        //int sum = 0;
        //int count = 0;
        //while (count < 5)
        //{
        //    Console.Write($"Enter integer #{count + 1}: ");
        //    string aInput = Console.ReadLine();
        //    bool isValid = int.TryParse(aInput, out int number);
        //    if (isValid)
        //    {
        //        sum += number;
        //        count++;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid integer.");
        //    }
        //}
        //Console.WriteLine(sum);


        //Exercise 8
        //Write a program that reads five numbers from the console and prints the greatest of them.
        //int max = int.MinValue;
        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.Write($"Enter number #{i}: ");
        //    string input = Console.ReadLine();

        //    bool isInputValid = int.TryParse(input, out int number);
        //    if (isInputValid)
        //    {
        //        if (number > max)
        //        {
        //            max = number;
        //        }             
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input, pls try again.");
        //        i--;
        //    }
        //}
        //Console.WriteLine($"\nThe greatest number is: {max}");


        //Exercise 9
        //Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
        //Console.Write("Enter how many numbers you want to sum? ");
        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write($"Enter number #{i}: ");
        //    int number = int.Parse(Console.ReadLine());
        //    sum += number;
        //}
        //Console.WriteLine(sum);


        //Exercise 10
        //Write a program that reads an integer number n from the console and prints all numbers in the range[1…n], each on a separate line. 
        //Console.Write("Enter n number: ");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    Console.WriteLine(i);
        //}



        //Exercise 11
        //Write a program that prints on the console the first 100 numbers in theFibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … 

        //int a = 0;
        //int b = 1;
        //int c;
        //Console.Write("Enter a number: ");
        //string nInput = Console.ReadLine();
        //bool isValid = int.TryParse(nInput, out int n);
        //if (isValid)
        //{
        //    Console.WriteLine("Fibonacci series: ");
        //    for (var i = 0; i < n; i++)
        //    {
        //        Console.Write(a + " ");
        //        c = a + b;
        //        a = b;
        //        b = c;
        //    }
        //    //Console.WriteLine();
        //}
        //else
        //{
        //    Console.WriteLine("Invalid numbers.");
        //}


        //Conditional Statement

        //string str = "beer";
        //string anotherStr = str;
        //string thirdStr = "bee";
        //thirdStr = thirdStr + "r";
        //Console.WriteLine("str = {0}", str);
        //Console.WriteLine("anotherStr = {0}", anotherStr);
        //Console.WriteLine("thirdStr = {0}", thirdStr);
        //Console.WriteLine(str == anotherStr); // True - same object 
        //Console.WriteLine(str == thirdStr); // True - equal objects 
        //Console.WriteLine((object)str == (object)anotherStr); // True 
        //Console.WriteLine((object)str == (object)thirdStr); // False

        //int x = 2;
        //if (x < 3)
        //{
        //    Console.WriteLine("X is greater than 3");
        //}
        //else
        //{
        //    Console.WriteLine("X is not greater than 3");
        //}


        //int first = 5; int second = 10;
        //if (first == second)
        //{
        //    Console.WriteLine("they are equal");
        //}
        //else
        //{
        //    if (first > second)
        //    {
        //        Console.WriteLine("First is greater");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Second is greater");
        //    }
        //}


        //char ch = 'X';
        //if (ch == 'A' || ch == 'a')
        //{
        //    Console.WriteLine("Vowel [ei]");
        //}
        //else if (ch == 'E' || ch == 'e')
        //{
        //    Console.WriteLine("Vowel [i:]");
        //}
        //else if (ch == 'I' || ch == 'i')
        //{
        //    Console.WriteLine("Vowel [ai]");
        //}
        //else if (ch == 'O' || ch == 'o')
        //{
        //    Console.WriteLine("Vowel [ou]");
        //}
        //else if (ch == 'U' || ch == 'u')
        //{
        //    Console.WriteLine("Vowel [ju:]");
        //}
        //else
        //{
        //    Console.WriteLine("Consonant");
        //}


        //Chapter 5
        //Exercise 1
        //Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
        //Console.Write("Enter first number: ");
        //int num1 = int.Parse(Console.ReadLine());
        //Console.Write("Enter second number: ");
        //int num2 = int.Parse(Console.ReadLine());
        //int bigger = 0;
        //if (num1 > num2)
        //{
        //    bigger = num1;
        //    num1 = num2;
        //    num2 = bigger;
        //    Console.WriteLine(num1);
        //    Console.WriteLine(num2);
        //}
        //else
        //{
        //    bigger = num2;
        //    num2 = num1;
        //    num1 = bigger;
        //    Console.WriteLine(num1);
        //    Console.WriteLine(num2);
        //}


        //Exercise 2
        //Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it.Use a sequence of if operators.
        //Console.Write("Enter first number: ");
        //int num1 = int.Parse(Console.ReadLine());
        //Console.Write("Enter second number: ");
        //int num2 = int.Parse(Console.ReadLine());
        //Console.Write("Enter third number: ");
        //int num3 = int.Parse(Console.ReadLine());
        //if (num1 == 0 || num2 == 0 || num3 == 0)
        //{
        //    Console.WriteLine("0");
        //}
        //else
        //{
        //    if (num1 > 0 && num2 > 0 && num3 > 0)
        //    {
        //        Console.WriteLine("+");
        //    }
        //    else if (num1 < 0 && num2 < 0 && num3 > 0)
        //    {
        //        Console.WriteLine("+");
        //    }
        //    else if (num1 < 0 && num3 < 0 && num2 > 0)
        //    {
        //        Console.WriteLine("+");
        //    }
        //    else if (num2 < 0 && num3 < 0 && num1 > 0)
        //    {
        //        Console.WriteLine("+");
        //    }
        //    else
        //    {
        //        if (num1 < 0 && num2 < 0 && num3 < 0)
        //        {
        //            Console.WriteLine("-");
        //        }
        //        else if (num1 > 0 && num2 > 0 && num3 < 0)
        //        {
        //            Console.WriteLine("-");
        //        }
        //        else if (num1 > 0 && num3 > 0 && num2 < 0)
        //        {
        //            Console.WriteLine("-");
        //        }
        //        else if (num2 > 0 && num3 > 0 && num1 < 0)
        //        {
        //            Console.WriteLine("-");
        //        }
        //    }
        //}


        //Exercise 3
        //Write a program that finds the biggest of three integers, using nested if statements.
        //Console.Write("Enter first number #: ");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.Write("Enter second number #: ");
        //int num2 = int.Parse(Console.ReadLine());

        //Console.Write("Enter third number #: ");
        //int num3 = int.Parse(Console.ReadLine());

        //if (num1 == num2 && num1 == num3)
        //{
        //    Console.WriteLine("The three numbers are equal.");
        //}
        //else
        //{
        //    if (num1 > num2 && num1 > num3)
        //    {
        //        Console.WriteLine($"Num1 is the biggest number with the value: {num1}.");
        //    }
        //    if (num2 > num3 && num2 > num1)
        //    {
        //        Console.WriteLine($"Num2 is the biggest number with the value: {num2}.");
        //    }
        //    if (num3 > num1 && num3 > num2)
        //    {
        //        Console.WriteLine($"Num3 is the biggest number with the value: {num3}.");
        //    }
        //}


        //Exercise 4
        //Sort 3 real numbers in descending order. Use nested if statements. 
        //Console.Write("Enter first number: ");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //int num2 = int.Parse(Console.ReadLine());

        //Console.Write("Enter third number: ");
        //int num3 = int.Parse(Console.ReadLine());

        //if (num1 > num2 && num1 > num3)
        //{
        //    if (num2 > num3)
        //    {
        //        Console.WriteLine($"{num1} {num2} {num3}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num1} {num3} {num2}");
        //    }
        //}
        //if (num2 > num1 && num2 > num3)
        //{
        //    if (num1 > num3)
        //    {
        //        Console.WriteLine($"{num2} {num1} {num3}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num2} {num3} {num1}");
        //    }
        //}
        //if (num3 > num1 && num3 > num2)
        //{
        //    if (num1 > num2)
        //    {
        //        Console.WriteLine($"{num3} {num1} {num2}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num3} {num2} {num1}"); 
        //    }
        //}


        //Exercise 5
        //Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word(in English).Use a switch statement.
        //Console.Write("Enter 0-9 number: ");
        //int num = int.Parse(Console.ReadLine());
        //switch (num)
        //{
        //    case 0:
        //    Console.WriteLine("Zero");
        //    break;

        //    case 1:
        //    Console.WriteLine("One");
        //    break;

        //    case 2:
        //    Console.WriteLine("Two");
        //    break;

        //    case 3:
        //    Console.WriteLine("Three");
        //    break;

        //    case 4:
        //    Console.WriteLine("Four");
        //    break;

        //    case 5:
        //    Console.WriteLine("Five");
        //    break;

        //    case 6:
        //    Console.WriteLine("Six");
        //    break;

        //    case 7:
        //    Console.WriteLine("Seven");
        //    break;

        //    case 8:
        //    Console.WriteLine("Eight");
        //    break;

        //    case 9:
        //    Console.WriteLine("Nine");
        //    break;
        //    default:
        //    Console.WriteLine("Invalid");
        //    break;
        //}


        //Exercise 6
        //Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots(if they exist). Quadratic equations may have 0, 1 or 2 real roots.
        //Console.Write("Enter first number: ");
        //int a = int.Parse(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //int b = int.Parse(Console.ReadLine());

        //Console.Write("Enter third number: ");
        //int c = int.Parse(Console.ReadLine());
        //double oneRootX1 = 0;
        //double twoRootX2 = 0;
        //double noRootX3 = 0;
        ////Discriminant D = b2 - 4ac.
        //double d = (double)(b * 2) - (4 * a * c);
        //if (d >= 0)
        //{
        //    //the equation has two distinct real roots(Positive)
        //    twoRootX2 = (double)((-b) + Math.Sqrt(d)) / (2 * a);
        //    //Negative
        //    noRootX3 = (double)((-b) - Math.Sqrt(d)) / (2 * a);
        //    Console.WriteLine(twoRootX2);
        //    Console.WriteLine(noRootX3);
        //}
        //else
        //{
        //    Console.WriteLine("No real root");
        //}



        //Exercise 7
        //Write a program that finds the greatest of given 5 numbers.
        //Console.Write("Enter first number: ");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //int num2 = int.Parse(Console.ReadLine());

        //Console.Write("Enter third number: ");
        //int num3 = int.Parse(Console.ReadLine());

        //Console.Write("Enter fourth number: ");
        //int num4 = int.Parse(Console.ReadLine());

        //Console.Write("Enter fifth number: ");
        //int num5 = int.Parse(Console.ReadLine());

        //if (num1 == num2 || num1 == num3 || num1 == num4 || num1 == num5)
        //{
        //    Console.WriteLine("They are equals.");
        //}
        //else
        //{
        //    if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
        //    {
        //        Console.WriteLine($"Num1 is the greatest number with the value: {num1}");
        //    }
        //    if (num2 > num3 && num2 > num4 && num2 > num5 && num2 > num1)
        //    {
        //        Console.WriteLine($"Num2 is the greatest number with the value: {num2}");
        //    }
        //    if (num3 > num4 && num3 > num5 && num3 > num1 && num3 > num2)
        //    {
        //        Console.WriteLine($"Num3 is the greatest number with the value: {num3}");
        //    }
        //    if (num4 > num5 && num4 > num1 && num4 > num2 && num4 > 3)
        //    {
        //        Console.WriteLine($"Num4 is the greatest number with the value: {num4}");
        //    }
        //    if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
        //    {
        //        Console.WriteLine($"Num5 is the greatest number with the value: {num5}");
        //    }
        //}


        //Exercise 8
        //Write a program that, depending on the user’s choice, inputs int, doubleor string variable. If the variable is int or double, the program
        //increases it by 1.If the variable is a string, the program appends "*" at the end.Print the result at the console. Use switch statement.
        //Console.Write("Enter a for integer, b for double and c for string: ");
        //char choice = char.Parse(Console.ReadLine());
        //switch (choice)
        //{
        //    case 'a':
        //    case 'A':
        //    Console.Write("Enter an integer number: ");
        //    int num = int.Parse(Console.ReadLine());
        //    Console.WriteLine(num + 1);
        //    break;

        //    case 'b':
        //    case 'B':
        //    Console.Write("Enter a double number: ");
        //    double doubleNum = double.Parse(Console.ReadLine());
        //    Console.WriteLine(doubleNum + 1);
        //    break;

        //    case 'c':
        //    case 'C':
        //    Console.Write("Enter a string input: ");
        //    string input = Console.ReadLine();
        //    Console.WriteLine(input + "*");
        //    break;
        //    default:
        //    break;
        //}


        //Exercise 9
        //We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0.
        //Console.Write("Enter first number: ");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //int num2 = int.Parse(Console.ReadLine());

        //Console.Write("Enter third number: ");
        //int num3 = int.Parse(Console.ReadLine());

        //Console.Write("Enter fourth number: ");
        //int num4 = int.Parse(Console.ReadLine());

        //Console.Write("Enter fifth number: ");
        //int num5 = int.Parse(Console.ReadLine());

        //if ((num1 + num2) == 0)
        //{
        //    Console.WriteLine("The subset is: " + num1 + num2);
        //}
        //else if ((num1 + num2 + num3) == 0)
        //{
        //    Console.WriteLine("The subset is: " + num1 + num2 + num3);
        //}
        //else if ((num1 + num2 + num3 + num4) == 0)
        //{
        //    Console.WriteLine("The subset is: " + num1 + num2 + num3 + num4);
        //}
        //else if ((num1 + num2 + num3 + num4 + num5) == 0)
        //{
        //    Console.WriteLine("The subset is: " + num1 + num2 + num3 + num4 + num5);
        //}
        //else
        //{
        //    if ((num2 + num3) == 0)
        //    {
        //        Console.WriteLine("The subset is: " + num2 + num3);
        //    }
        //    else if ((num2 + num3 + num4 ) == 0)
        //    {
        //        Console.WriteLine("The subset is: " + num2 + num3 + num4);
        //    }
        //    else if ((num2  + num3 + num4 + num5) == 0)
        //    {
        //        Console.WriteLine("The subset is: " + num2 + num3 + num4 + num5);
        //    }
        //    else
        //    {
        //        if ((num3 + num4) == 0)
        //        {
        //            Console.WriteLine("The subset is: " + num3 + num4);
        //        }
        //        else if ((num3 + num4 + num5 ) == 0)
        //        {
        //            Console.WriteLine("The subset is: " + num3 + num4 + num5);
        //        }
        //        else
        //        {
        //            if ((num4 + num5) == 0)
        //            {
        //                Console.WriteLine("The subset is: " + num4 + num5);
        //            }
        //        }
        //    }
        //}



        //Exercise 10
        //Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
        //Console.Write("Enter 1-9 number: ");
        //int num = int.Parse(Console.ReadLine());

        //switch (num)
        //{
        //    case 1:
        //    case 2:
        //    case 3:
        //    Console.WriteLine("The points to given scores is " + (num * 10));
        //    break;
        //    case 4:
        //    case 5:
        //    case 6:
        //    Console.WriteLine("The points to given scores is " + (num * 100));
        //    break;
        //    case 7:
        //    case 8:
        //    case 9:
        //    Console.WriteLine("The points to given scores is " + (num * 1000));
        //    break;
        //    default:
        //    Console.WriteLine("Invalid number");
        //    break;
        //}


        //Exercise 11




        //Loop
        //While Loop
        //int num = 0;
        //while (num <= 9)
        //{
        //    Console.WriteLine("Number: " + num);
        //    num++;
        //}


        //Console.Write("Enter N = ");
        //int n = int.Parse(Console.ReadLine());
        //int num = 1;
        //int sum = 1;
        //Console.Write("The sum 1");
        //while(num < n)
        //{
        //    num++;
        //    sum += num;
        //    Console.Write(" + " +  num);
        //}
        //Console.WriteLine(" = " + sum);


        //Prime
        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //int divider = 2;
        //int maxDivider = (int)Math.Sqrt(num);
        //bool prime = true;
        //while(prime && (divider <= maxDivider))
        //{
        //    if (num % divider == 0)
        //    {
        //        prime = false;
        //    }
        //    divider++;
        //}
        //Console.WriteLine("Prime " + prime);


        //Factorial
        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //decimal factorial = 1;
        //while (true)
        //{
        //    if (num <= 1)
        //    {
        //        break;
        //    }
        //    factorial *= num;
        //    num--;
        //}
        //Console.WriteLine("N! = " + factorial);


        //Do While Loop
        //Factorial
        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //decimal factorial = 1;
        //do
        //{
        //    if (num <= 1)
        //    {
        //        break;
        //    }
        //    factorial *= num;
        //    num--;
        //}
        //while (true);
        //Console.WriteLine("N! = " + factorial);

        // Or

        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //decimal factorial = 1;
        //do
        //{
        //    factorial *= num;
        //    num--;
        //}
        //while (num > 0);
        //Console.WriteLine("N! = " + factorial);

        //OR for big values
        //Console.Write("N = ");
        //int num = int.Parse(Console.ReadLine());
        //BigInteger factorial = 1;
        //do
        //{
        //    factorial = factorial *= num;
        //    num--;
        //}
        //while (num > 0);
        //Console.WriteLine("N! = " + factorial);


        //Product of numbers
        //Console.Write("N = ");
        //int n = int.Parse(Console.ReadLine());

        //Console.Write("M = ");
        //int m = int.Parse(Console.ReadLine());

        //int num = n;
        //long product = 1;
        //do
        //{
        //    product *= num;
        //    num++;
        //}
        //while (num <= m);
        //Console.WriteLine("Product [n...m] " + product);


        //For Loop
        //for (int i = 0; i <= 10; i++)
        //{
        //    Console.Write(" " + i);
        //}


        //Console.Write("n = ");
        //int n = int.Parse(Console.ReadLine());

        //Console.Write("m = ");
        //int m = int.Parse(Console.ReadLine());

        //decimal result = 1;
        //for (int i = 0; i < m; i++)
        //{
        //    result *= n;
        //}
        //Console.WriteLine("{n^m} = " + result);


        //Console.Write("n = ");
        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;
        //for (int i = 1; i <= n; i += 2)
        //{
        //    if (i % 7 == 0)
        //    {
        //        continue;
        //    }
        //    sum += i;
        //}
        //Console.WriteLine("Sum = " + sum);


        //For each Loop
        //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //foreach (int i in array)
        //{
        //    Console.Write(" " + i);
        //}
        //Console.WriteLine();


        //string[] towns = { "Canada", "London", "Paris", "New York", "Milan" };
        //foreach (string name in towns)
        //{
        //    Console.WriteLine(" " + name);
        //}
        //Console.WriteLine();


        //int[] array = { 1, 2, 3, 4 };
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write(" " +  array[i]);
        //}
        //Console.WriteLine();


        //string[] towns = { "Canada", "London", "Paris", "New York", "Milan" };

        //for (int i = 0; i < towns.Length; i++)
        //{
        //    Console.Write(" " + towns[i]);
        //}
        //Console.WriteLine();


        //Nested For Loop
        //Console.Write("Pls enter a number: ");
        //int num = int.Parse(Console.ReadLine());

        //for (int row = 1; row <= num; row++)
        //{
        //    for (int col = 1; col <= row; col++)
        //    {
        //        Console.Write(" " + col);
        //    }
        //    Console.WriteLine();
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

        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //decimal factorial = 1;
        //for (int i = number; i <= number; i--)
        //{
        //    if (i <= 0)
        //    {
        //        break;
        //    }
        //    factorial *= i;
        //}
        //Console.WriteLine(number +"! = " + factorial);


        //Lucky Numbers
        //Console.Write("Enter lucky number: ");
        //int number = int.Parse(Console.ReadLine());
        //for (int a = 1; a <= number; a++)
        //{
        //    for (int b = 0; b <= number; b++)
        //    {
        //        for (int c = 0; c <= number; c++)
        //        {
        //            for (int d = 0; d <= number; d++)
        //            {
        //                if ((a + b) == (c + d))
        //                {
        //                    Console.WriteLine("" + a + " " + b + " " + c + " " + d);
        //                }
        //            }
        //        }
        //    }
        //}


        //Console.Write("Enter lucky number: ");
        //int number = int.Parse(Console.ReadLine());
        //for (int a = 1; a <= number; a++)
        //{
        //    for (int b = 0; b <= number; b++)
        //    {
        //        for (int c = 0; c <= number; c++)
        //        {
        //            Console.WriteLine(a + " " + b + " " + c);
        //        }
        //    }
        //}


        //Chapter 6
        //Exercises 1
        //Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
        //Console.Write("Enter N = ");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    Console.Write(" " + i);
        //}


        //Exercises 2
        //Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.The number N should be read from the standard input.
        //Console.Write("Enter N = ");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    if (((i % 3) == 0) || ((i % 7) == 0))
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(" " + i);
        //}

        //Or

        //Console.WriteLine("Enter N");
        //int b = int.Parse(Console.ReadLine());
        //for (int i = 1; i < b; i++)
        //{
        //    if (i % 3 != 0 && i % 7 != 0)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}

        //Exercises 3
        //Write a program that reads from the console a series of integers and prints the smallest and largest of them.
        //Console.Write("Enter N = ");
        //int n = int.Parse(Console.ReadLine());
        //int smallest = int.MaxValue;
        //int biggest = int.MinValue;
        //for (int i = 1; i <= n; i++)
        //{
        //    Console.Write("Enter a number: ");
        //    int num = int.Parse(Console.ReadLine());
        //    if (num > biggest)
        //    {
        //        biggest = num;
        //    }
        //    else if (num < smallest)
        //    {
        //        smallest = num;
        //    }
        //    Console.WriteLine("The smallest number is = " + smallest + " And the biggest number is = " + biggest);
        //}


        //Exercises 4
        //Write a program that prints all possible cards from a standard deck of cards, without jokers(there are 52 cards: 4 suits of 13 cards)
        //for (int i = 1; i <= 4; i++)
        //{
        //    for (int j = 1; j <= 13; j++)
        //    {
        //        switch (i)
        //        {
        //            case 1:
        //            Console.WriteLine("Club");
        //            break;
        //            case 2:
        //            Console.WriteLine("Diamond");
        //            break;
        //            case 3:
        //            Console.WriteLine("Heart");
        //            break;
        //            case 4:
        //            Console.WriteLine("Spades");
        //            break;
        //            default:
        //            break;
        //        }

        //        switch (j)
        //        {
        //            case 2:
        //            Console.WriteLine("2");
        //            break;
        //            case 3:
        //            Console.WriteLine("3");
        //            break;
        //            case 4:
        //            Console.WriteLine("4");
        //            break;
        //            case 5:
        //            Console.WriteLine("5");
        //            break;
        //            case 6:
        //            Console.WriteLine("6");
        //            break;
        //            case 7:
        //            Console.WriteLine("7");
        //            break;
        //            case 8:
        //            Console.WriteLine("8");
        //            break;
        //            case 9:
        //            Console.WriteLine("9");
        //            break;
        //            case 10:
        //            Console.WriteLine("10");
        //            break;
        //            case 11:
        //            Console.WriteLine("J");
        //            break;
        //            case 12:
        //            Console.WriteLine("Q");
        //            break;
        //            case 13:
        //            Console.WriteLine("K");
        //            break;
        //            case 14:
        //            Console.WriteLine("A");
        //            break;
        //            default:
        //            Console.WriteLine("Invalid");
        //            break;
        //        }
        //    }
        //}


        //Exercise 5
        //Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … 
        //int firstNumber = 0;
        //int secondNumber = 1;
        //int thirdNumber = 0;
        //Console.Write("Enter N = ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Fibonacci series: ");
        //for (int i = 1; i <= n; i++)
        //{
        //    Console.Write(" " + firstNumber);
        //    thirdNumber = firstNumber + secondNumber;
        //    firstNumber = secondNumber;
        //    secondNumber = thirdNumber;
        //}


        //Exercise 6
        //Write a program that calculates N!/K! for given N and K (1<K<N).
        //Console.Write("Enter N = ");
        //int n = int.Parse(Console.ReadLine());
        //decimal nFactorial = 1;
        //decimal kFactorial = 1;
        //for (int i = n; i <= n; i--)
        //{
        //    if (i <= 0)
        //    {
        //        break;
        //    }
        //    nFactorial = nFactorial *= i;
        //    kFactorial = kFactorial *= i;
        //}
        //Console.WriteLine("N! = " + nFactorial);
        //Console.WriteLine("K! = " + kFactorial);
        //Console.WriteLine(nFactorial / kFactorial);


        //Exercise 7
        //Write a program that calculates N!*K!/(N-K)! for given N and K (1 < K < N).
        //Console.Write("Enter N = ");
        //int n = int.Parse(Console.ReadLine());

        //Console.Write("Enter K = ");
        //int k = int.Parse(Console.ReadLine());

        //decimal nFactorial = 1;
        //decimal kFactorial = 1;
        //for (int i = n; i <= n; i--)
        //{
        //    if (i <= 0)
        //    {
        //        break;
        //    }
        //    nFactorial *= i;
        //}
        //Console.WriteLine("N! = " + nFactorial);

        //for (int j = n; j <= k; j--)
        //{
        //    if (j <= 0)
        //    {
        //        break;
        //    }
        //    kFactorial *= j;
        //}
        //Console.WriteLine("K! = " + kFactorial);
        //Console.WriteLine("N!*K! = " + (nFactorial * kFactorial));
        //Console.WriteLine("(N-K)! = " + (nFactorial - kFactorial));
        //Console.WriteLine("N!*K!/(N-K)! = " + ((nFactorial * kFactorial) / (nFactorial - kFactorial)));


        //Exercise 10
        //Write a program that reads from the console a positive integer number N(N < 20) and prints a matrix of numbers as on the figures below:
        //Console.Write("Enter N = ");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = i; j <= i + (n - 1); j++)
        //    {
        //        Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        //}


        //Chapter 7
        //Array
        //int[] myArray = new int[5];
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    myArray[i] = i;
        //    Console.WriteLine(myArray[i]);
        //}


        //int[] array = { 1, 2, 3, 4, 5, 6 };
        //Console.WriteLine(array[3]);

        //Reverse Array
        //int[] myArray = { 1, 2, 3, 4, 5 };
        //int length = myArray.Length;
        //int[] reverseArray = new int[length];
        //for (int i = 0; i < length; i++)
        //{
        //    reverseArray[length - i - 1] = myArray[i];
        //}

        //for (int i = 0; i < length; ++i)
        //{
        //    Console.Write(reverseArray[i] + " ");
        //}


        //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        //int length = myArray.Length;
        //int[] reverse = new int[length];
        //for (int i = 0; i < length; i++)
        //{
        //    reverse[length - i - 1] = myArray[i];
        //}
        //for (int i = 0; i < length; ++i)
        //{
        //    Console.Write(reverse[i] + " ");
        //}


        //Console.Write("Enter a number: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] myArray = new int[n];
        //Console.Write($"Enter {n} numbers: ");
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write($"Enter {i}#: ");
        //    myArray[i] = int.Parse(Console.ReadLine());
        //    Console.WriteLine(myArray[i] + " ");
        //}


        //Symmetric Array
        //Console.Write("Enter N: ");
        //int n = int.Parse(Console.ReadLine());

        //int[] array = new int[n];
        //Console.Write("Enter array value: ");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //bool isSymmetric = true;
        //for (int i = 0; i < array.Length / 2; i++)
        //{
        //    if (array[i] != array[n - i - 1])
        //    {
        //        isSymmetric = false;
        //        break;
        //    }
        //}
        //Console.WriteLine("Symmetric? {0}", isSymmetric);


        //string[] array = { "One", "Two", "Three", "Four", "Five" };
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.WriteLine(array[i]);
        //}


        //int[] array = { 1, 2, 3, 4, 5 };
        //int length = array.Length;
        //for (int i = 0; i < length; i++)
        //{
        //    array[i] = array[i] * 2;
        //    Console.Write(array[i] + " ");
        //}

        //Or

        //int[] myArray = { 1, 2, 3, 4, 5 };
        //int length = myArray.Length;
        //for (int i = 0; i < length; i++)
        //{
        //    myArray[i] *= 2;
        //    Console.Write(myArray[i] + " ");
        //}


        //int[] num = new int[] {1, 2, 3, 4, 5};
        //for (int i = 0; i < num.Length; i += 2)
        //{
        //    num[i] = num[i] * num[i];
        //    Console.Write(num[i] + " ");
        //}


        //int[] array = { 1, 2, 3, 4, 5 };
        //int length = array.Length;
        //int[] reverse = new int[length];
        //for (int i = 0; i < length; i++)
        //{
        //    reverse[length - i - 1] = array[i];
        //}

        //for (int i = 0; i < length; ++i)
        //{
        //    Console.Write(reverse[i] + " ");  
        //}

        //Or

        //int[] myArray = { 1, 2, 3, 4, 5 };
        //int length = myArray.Length;
        //for (int i = length - 1; i >= 0; i--)
        //{
        //    if (i < 0)
        //    {
        //        break;
        //    }
        //    Console.Write(myArray[i]);
        //}
        //Console.WriteLine();

        //Or


        //int[] number = {1, 2, 3, 4, 5};
        //int length = number.Length;
        //for (int i = length - 1; i >= 0; i--)
        //{
        //    Console.Write(number[i] + " ");
        //}

        //int[] myArray = { 1, 2, 3, 4, 5 };
        //foreach (int i in myArray)
        //{
        //    Console.WriteLine(i);
        //}

        //Multidimensional Array
        //myArray.GetLength(0) Returns the number of rows = 2
        //myArray.GetLength(1) Returns the number of all columns per row = 5
        //int[,] myArray =
        //{
        //    { 1, 2, 3, 4, 5 },
        //    { 6, 7, 8, 9, 10 }
        //};

        //for (int row = 0; row < myArray.GetLength(0); row++)
        //{
        //    for (int col = 0; col < myArray.GetLength(1); col++)
        //    {
        //        Console.Write(myArray[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}


        //Console.Write("Enter number of rows: ");
        //int rows = int.Parse(Console.ReadLine());

        //Console.Write("Enter number of columns: ");
        //int cols = int.Parse(Console.ReadLine());

        //int[,] matrix = new int[rows, cols];
        //Console.WriteLine("Enter the ceils of the matrix: ");
        //for (int row = 0; row < rows; row++)
        //{
        //    for (int col = 0; col < cols; col++)
        //    {
        //        Console.Write("Matrix[{0},{1}] = ", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write(" " + matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}


        //Console.Write("Enter number of rows: ");
        //int rows = int.Parse(Console.ReadLine());

        //Console.Write("Enter number of columns: ");
        //int cols = int.Parse(Console.ReadLine());

        //int[,] matrix = new int[rows, cols];
        //Console.WriteLine("Enter the ceils of the matrix: ");
        //for (int row = 0; row < rows; row++)
        //{
        //    for (int col = 0; col < cols; col++)
        //    {
        //        Console.Write("Matrix[{0},{1}] = ", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}


        //int[,] matrix =
        //{
        //    { 1, 2, 3, 4, 5, 6 },
        //    { 7, 8, 9, 10, 11, 12 },
        //    { 13, 14, 15, 16, 17, 18 },
        //    { 19, 20, 21, 22, 23, 24 },
        //    { 25, 26, 27, 28, 29, 30 }
        //};

        //long bestSum = long.MinValue;
        //int bestRow = 0;
        //int bestCol = 0;

        //for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        //    {
        //        long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
        //        if (sum > bestRow)
        //        {
        //            bestSum = sum;
        //            bestRow = row;
        //            bestCol = col;
        //        }
        //    }
        //}
        //Console.WriteLine("The 2 * 2 matrix is: ");
        //Console.WriteLine(" {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
        //Console.WriteLine(" {0} {1}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
        //Console.WriteLine("The best sum is {0} = ", bestSum);


        //int[,] myArray =
        //{
        //    { 1, 2, 3, 4, 5, 6 },
        //    { 2, 3, 4, 5, 6, 7 },
        //    { 3, 4, 5, 6, 7, 8 },
        //    { 4, 5, 6, 7, 8, 9 },
        //    { 5, 6, 7, 8, 9, 10 }
        //};

        //long bestSum = long.MinValue;
        //int bestRow = 0;
        //int bestCol = 0;

        //for (int row = 0; row < myArray.GetLength(0) - 1; row++)
        //{
        //    for (int col = 0; col < myArray.GetLength(1) - 1; col++)
        //    {
        //        long sum = myArray[row, col] + myArray[row, col + 1] + myArray[row + 1, col] + myArray[row + 1, col + 1];
        //        if (sum > bestSum)
        //        {
        //            bestSum = sum;
        //            bestRow = row;
        //            bestCol = col;
        //        }
        //    }
        //}
        //Console.WriteLine("The best platform: ");
        //Console.WriteLine(" {0} {1}", myArray[bestRow, bestCol], myArray[bestRow, bestCol + 1]);
        //Console.WriteLine(" {0} {1}", myArray[bestRow + 1, bestCol], myArray[bestRow + 1, bestCol + 1]);
        //Console.WriteLine("The best sum is: {0}", bestSum);


        //Arrays Of Arrays(Jagged Array)
        //int[][] jaggedArray = new int[4][];
        //int length = jaggedArray.Length;
        //Console.WriteLine("Enter ceils of an Array: ");
        //for (int i = 0; i < length; i++)
        //{
        //    jaggedArray[i][i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = 0;i < length; i++)
        //{
        //    Console.Write(jaggedArray[i][i] + " ");
        //}


        //int[][] array =
        //{
        //    new int[] { 1, 2, 3 },
        //    new int[] { 4, 5, 6 },
        //    new int[] { 7, 8, 9 }
        //};
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write(array[i][2] + " ");
        //}


        // const int HEIGHT = 12;
        // Allocate the array in a triangle form
        //long[][] triangle = new long[HEIGHT + 1][];
        //for (int row = 0; row < HEIGHT; row++)
        //{
        //    triangle[row] = new long[row + 1];
        //}
        // Calculate the Pascal's triangle
        //triangle[0][0] = 1;
        //for (int row = 0; row < HEIGHT - 1; row++)
        //{
        //    for (int col = 0; col <= row; col++)
        //    {
        //        triangle[row + 1][col] += triangle[row][col];
        //        triangle[row + 1][col + 1] += triangle[row][col];
        //    }
        //}
        // Print the Pascal's triangle
        //for (int row = 0; row < HEIGHT; row++)
        //{
        //    Console.Write("".PadLeft((HEIGHT - row) * 2));
        //    for (int col = 0; col <= row; col++)
        //    {
        //        Console.Write("{0,3} ", triangle[row][col]);
        //    }
        //    Console.WriteLine();
        //}


        //Chapter 7
        //Exercise 1
        //Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5.Print the elements to the console.    
        //int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    myArray[i] *= 5;
        //    Console.Write(myArray[i] + " ");
        //}
        //Console.WriteLine();


        //Exercise 2
        //Write a program, which reads two arrays from the console and checks whether they are equal(two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).
        //Console.Write("Enter first array length: ");
        //int firstLength = int.Parse(Console.ReadLine());

        //int[] firstArray = new int[firstLength];

        //for (int i = 0; i < firstArray.Length; i++)
        //{
        //    firstArray[i] = int.Parse(Console.ReadLine());
        //}

        //Console.Write("Enter second array length: ");
        //int secondLength = int.Parse(Console.ReadLine());

        //int[] secondArray = new int[secondLength];

        //for (int j = 0; j < secondArray.Length; j++)
        //{
        //    secondArray[j] = int.Parse(Console.ReadLine());
        //}

        //if (firstLength == secondLength)
        //{
        //    for (int i = 0; i < firstArray.Length; i++)
        //    {
        //        if (firstArray[i] != secondArray[i])
        //        {
        //            Console.WriteLine("They are not equal");
        //        }
        //        else
        //        {
        //            Console.WriteLine("They are equal");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("The length are not equal");
        //}


        //Exercise 3
        //Write a program, which compares two arrays of type char lexicographically(character by character) and checks, which one is first in the lexicographical order.
        //Console.Write("Enter the length of the first array: ");
        //int length1 = int.Parse(Console.ReadLine());

        //char[] charArray1 = new char[length1];
        //Console.WriteLine("Enter the ceil of the first element in an array: ");

        //for (int i = 0; i < charArray1.Length; i++)
        //{
        //    charArray1[i] = char.Parse(Console.ReadLine());
        //}

        //Console.Write("Enter the length of the second array: ");
        //int length2 = int.Parse(Console.ReadLine());

        //char[] charArray2 = new char[length2];
        //Console.WriteLine("Enter the ceil of the second element in an array: ");

        //for (int i = 0; i < charArray2.Length; i++)
        //{
        //    charArray2[i] = char.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < charArray1.Length; i++)
        //{
        //    if (length1 != length2 && charArray1[i] != charArray2[i])
        //    {
        //        if (charArray1[i] > charArray2[i])
        //        {
        //            Console.Write("CharArray2 is lexicographically first");
        //            continue;
        //        }
        //        else
        //        {
        //            Console.Write("CharArray1 is lexicographically first ");
        //            continue;
        //        }
        //    }
        //    else if (length1 == length2 && charArray1[i] == charArray2[i])
        //    {
        //        Console.WriteLine("The arrays are equal");
        //    }
        //}

        //Exercise 4
        //Write a program, which finds themaximal sequence of consecutive equal elements in an array. E.g.: { 1, 1, 2, 3, 2, 2, 2, 1}  { 2, 2, 2}.
        //Console.Write("Enter length of an array: ");
        //int length = int.Parse(Console.ReadLine());

        //int[] array = new int[length];
        //int maxCount = 1;
        //int count = 1;
        //int maxElement = 0;
        //Console.WriteLine("Enter the ceil of an element of the array: ");
        //for (int i = 0; i < length; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < length - 1; i++)
        //{
        //    if (array[i] == array[i + 1])
        //    {
        //        count++;
        //    }

        //    if (count > maxCount)
        //    {
        //        maxCount = count;
        //        maxElement = array[i];
        //        count = 1;
        //    }
        //}

        //for (int i = 0; i < maxCount; i++)
        //{
        //    Console.Write(maxElement + " ");
        //}
        //Console.WriteLine();

        //Employer employ = new Employer();
        //Console.Write("Enter length of the array: ");
        //int length = int.Parse(Console.ReadLine());
        //Console.Write(employ.MaximalSequence(length) + " ");
        //Console.WriteLine();

        //Console.Write("Enter length of the array: ");
        //int length = int.Parse(Console.ReadLine());
        //Console.Write(employ.IncreasingIntegers(length) + " ");
        //Console.WriteLine();

        //Console.Write("Enter length of the array: ");
        //int length = int.Parse(Console.ReadLine());
        //Console.Write(employ.MaximalSequenceIncreasingEven(length) + " ");
        //Console.WriteLine();

        //Console.Write("Enter the length of the array: ");
        //int length = int.Parse(Console.ReadLine());
        //decimal[] prices = new decimal[length];
        //Console.WriteLine("Enter the element of an array: ");
        //for (int i = 0; i < length; i++)
        //{
        //    prices[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine(employ.TotalAmountOfBooks(prices));

        //Console.Write("Enter a number of your choice: ");
        //string number = Console.ReadLine();
        //bool isValid = int.TryParse(number, out int result);
        //if (isValid)
        //{
        //    Console.WriteLine(employ.PrintSign(result));
        //}
        //else
        //{
        //    Console.WriteLine("Enter a valid number.");
        //}


        //Console.Write("Enter first number: ");
        //string num1 = Console.ReadLine();

        //Console.Write("Enter second number: ");
        //string num2 = Console.ReadLine();

        //bool isFirstNumberValid = int.TryParse(num1, out int firstNumber);
        //bool isSecondNumberValid = int.TryParse(num2, out int secondNumber);

        //if (isFirstNumberValid && isSecondNumberValid)
        //{
        //    Console.WriteLine(employ.PrintMaxNumber(firstNumber, secondNumber));
        //}
        //else
        //{
        //    Console.WriteLine("Invalid number. Pls enter a valid number.");
        //}


        //Console.Write("Enter first number: ");
        //string num1 = Console.ReadLine();

        //Console.Write("Enter second number: ");
        //string num2 = Console.ReadLine();

        //bool isFirstNumberValid = int.TryParse(num1, out int firstNumber);
        //bool isSecondNumberValid = int.TryParse(num2, out int secondNumber);

        //if (isFirstNumberValid && isSecondNumberValid)
        //{
        //    Console.WriteLine(employ.PrintMaximumNumber(firstNumber, secondNumber));
        //}
        //else
        //{
        //    Console.WriteLine("Invalid number. Pls enter a valid number.");
        //}


        //Console.Write("Enter first number: ");
        //string num1 = Console.ReadLine();

        //Console.Write("Enter second number: ");
        //string num2 = Console.ReadLine();

        //bool isFirstNumberValid = int.TryParse(num1, out int firstNumber);
        //bool isSecondNumberValid = int.TryParse(num2, out int secondNumber);

        //if (isFirstNumberValid && isSecondNumberValid)
        //{
        //    Console.WriteLine(employ.PrintMaxOfNumbers(firstNumber, secondNumber));
        //}
        //else
        //{
        //    Console.WriteLine("Invalid number. Pls enter a valid number.");
        //}

        //employ.PrintNameAndAge("Miles", 25);
        //employ.PrintNumber(5);


        //int sum1 = employ.CalSum(1, 2);
        //int sum2 = employ.CalSum(1, 2, 3, 4);
        //int sum3 = employ.CalSum(4, 0, -2, 12);
        //int sum4 = employ.CalSum();
        //Console.WriteLine(sum1);
        //Console.WriteLine(sum2);
        //Console.WriteLine(sum3);
        //Console.WriteLine(sum4);

        //int sum1 = (int)employ.SumTotalPriceOfBooks(1000, 2000);
        //decimal sum2 = employ.SumTotalPriceOfBooks(10000, 20000, 30000, 40000);

        //decimal[] sum3 = new decimal[] {2000, 5000, 3000, 1000, 500};
        //decimal sum4 = employ.SumTotalPriceOfBooks(sum3);
        //Console.WriteLine(sum1);
        //Console.WriteLine(sum2);
        //Console.WriteLine(sum4);

        //employ.SomeMethod("What sup", "Hi", "Miles");
        //employ.SomeMethod("Miles", "Hi", ask: "What sup");
        //employ.SomeMethod(1.5f, 3);

        //employ.SomeMethod("Hello", "Mike");

        //employ.SomeMethod(5, 5.9f);
        //employ.SomeMethod("Hello", "Stella", "How are you");

        //Console.Write("Enter n: ");
        //int n = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= n; i++)
        //{
        //    employ.PrintTriangle(1, i);
        //}


        //for (int i = n - 1; i >= 1; i--)
        //{
        //    employ.PrintTriangle(1, i);
        //}

        //Console.Write("Enter n: ");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        //}


        //for (int i = n - 1; i >= 1; i--)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        //}

        //Console.Write("Enter first number: ");
        //int a = int.Parse(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //int b = int.Parse(Console.ReadLine());

        //decimal result = employ.Multiply(a, b);
        //Console.WriteLine(result);


        //employ.PositiveNumber(0);

        //Console.Write("Enter first number: ");
        //int a = int.Parse(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine(employ.GetTwoNumbers(a, b));


        //Console.Write("Enter  Temperature in Fahrenheit: ");
        //decimal temperature = decimal.Parse(Console.ReadLine());

        //temperature = employ.FahrenheitToCelsius(temperature);

        //Console.WriteLine("Your body temperature in Celsius degrees is {0}.", temperature);

        //if (temperature >= 37)
        //{
        //    Console.WriteLine("You are ill!");
        //}


        //Console.Write("Enter start month: ");
        //int startMonth = int.Parse(Console.ReadLine());

        //Console.Write("Enter end month: ");
        //int endMonth = int.Parse(Console.ReadLine());

        //employ.SetPeriod(startMonth, endMonth);

        //Console.Write("What time is it: ");

        //Console.Write("Enter hours: ");
        //int hours = int.Parse(Console.ReadLine());

        //Console.Write("Enter minutes: ");
        //int minutes = int.Parse(Console.ReadLine());

        //bool validTime = (employ.ValidateHours(hours)) && (employ.ValidateMinutes(minutes));
        //if (validTime)
        //{
        //    Console.WriteLine($"The time is {hours}:{minutes} now.");
        //}
        //else
        //{
        //    Console.WriteLine("Incorrect time!");
        //}


        //int[] numbers = employ.Sort(10, 3, 5, -1, 0, 12, 8);
        //employ.PrintNum(numbers);

        //Dog dog1 = new Dog();

        //dog1.Name = "Doggy";


        //dog1.Color = "Brown";


        //dog1.Description = "is a good dog";


        //dog1.Age = 1;
        //Console.Write("Enter dog name: ");
        //string name = Console.ReadLine();

        //Console.Write("Enter dog color: ");
        //string color = Console.ReadLine();

        //Console.Write("Enter dog description: ");
        //string description = Console.ReadLine();

        //Console.Write("Enter dog age: ");
        //int age = int.Parse(Console.ReadLine());

        //Dog dog2 = new Dog("Alpha", "Black", "Is a cute dog", 1);
        //Console.WriteLine("Dog {0} is {1} and {2} and {3} year old ", dog2.Name, dog2.Color, dog2.Description, dog2.Age);

        //Console.WriteLine($"{dog2.ValidateName(name)} is {dog2.ValidateColor(color)}, {dog2.ValidateDescription(description)} and is {dog2.ValidateAge(age)} years old.");

        //Console.Write("Enter a word: ");
        //string word = Console.ReadLine();

        //char[] charArray = word.ToCharArray();
        //Array.Reverse(charArray);

        //string reversed = new string(charArray);
        //Console.Write("Reversed: " + reversed);



        //Console.WriteLine("Enter the ceil of an element of an array: ");
        //string word = Console.ReadLine();
        //char[] charArray = word.ToCharArray();
        //char[] reversed = new char[charArray.Length];
        //for (int i = 0; i < charArray.Length; i++)
        //{
        //   reversed[charArray.Length - i - 1] = charArray[i];
        //}

        //for (int i = 0; i < reversed.Length; i++)
        //{
        //    Console.WriteLine(reversed[i] + " ");
        //}


        //Console.Write("Enter a word: ");
        //string word = Console.ReadLine();

        //char[] myChar = word.ToCharArray();
        //Array.Reverse(myChar);

        //string reverse = new string(myChar);
        //Console.Write("Reversed: " + reverse);

        //Room room = new Room(true);
        //room.RoomNumber = "R101";
        //room.UnBookRoom();
        //room.BookRoom();

        //Shape circle = new Circle(3);
        //Console.WriteLine(circle.GetArea());

        //Shape rectangle = new Rectangle(5, 7);
        //Console.WriteLine(rectangle.GetArea());

        //double salary = 50000;
        //double tax = 0.1;
        //double netSalary = salary - (salary * tax);
        //Console.WriteLine(netSalary);

        //Console.Write("Enter length of an array: ");
        //int length = int.Parse(Console.ReadLine());

        //int[] array = new int[length];
        //int count = 1;
        //int maxCount = 1;
        //Console.WriteLine("Enter ceil of an element of an array: ");
        //for (int i = 0; i < length; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < length - 1; i++)
        //{
        //    if (array[i] < array[i + 1])
        //    {
        //        count++;
        //        if (count > maxCount)
        //        {
        //            maxCount = count;
        //        }
        //    }
        //    else
        //    {
        //        count = 1;
        //    }
        //}
        //Console.Write(maxCount);

        //Circle circle = new Circle();
        //Console.WriteLine("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine(circle.Factorial(num));


        //Console.WriteLine("Enter m number: ");
        //int m = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter n number: ");
        //int n = int.Parse(Console.ReadLine());
        //circle.Prime(m, n);

        //Dog dog = new Dog();

        //Console.WriteLine("Sequence[1..3]: {0}, {1}, {2} ", Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());

        //Rectangle rectangle = new Rectangle();
        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= num; i++)
        //{
        //    Console.WriteLine(rectangle.RandomNumbers(46));
        //}

        //rectangle.PrintCount();

        //string fileName = "WrongTextFile.txt";
        //rectangle.ReadFile(fileName);

        //Exception e = new Exception("An exception occurred");
        //Console.WriteLine(e);

        //bool number;
        //string line = Console.ReadLine();
        //number = int.TryParse(line, out int num);
        //Console.WriteLine(number);

        //String
        //string message = "This is a sample message";
        //Console.WriteLine("message = {0} ", message);
        //Console.WriteLine("message = {0} ", message.Length);
        //for (int i = 0; i < message.Length; i++)
        //{
        //    Console.WriteLine("message [{0}] = {1} ", i, message[i]);
        //}

        //string quote = "Book's title is \"Intro to C#\" ";
        //Console.WriteLine(quote);

        //string email = "some@gmail.com";
        //Console.WriteLine($"My mail is: {email}");


        //string word1 = "C#";
        //string word2 = "c#";
        //Console.WriteLine(word1.Equals("C#"));
        //Console.WriteLine(word1.Equals(word2, StringComparison.CurrentCultureIgnoreCase));
        //Console.WriteLine(word1 == "C#");
        //string result1 = word2.ToUpper();
        //string result2 = word1.ToLower();
        //Console.WriteLine(word1 == word2);
        //Console.WriteLine(word1 == result1);
        //Console.WriteLine(result2 == word2);

        //string score = "sCore";
        //string scary = "scary";
        //Console.WriteLine(score.CompareTo(scary));
        //Console.WriteLine(scary.CompareTo(score));
        //Console.WriteLine(scary.CompareTo(scary));
        //Console.WriteLine(score.CompareTo(score));

        //Console.WriteLine();
        //Console.WriteLine(string.Compare(score, scary, StringComparison.CurrentCultureIgnoreCase));
        //Console.WriteLine(string.Compare(scary, score, StringComparison.CurrentCultureIgnoreCase));
        //Console.WriteLine(string.Compare(scary, scary, StringComparison.CurrentCultureIgnoreCase));
        //Console.WriteLine(string.Compare(score, score, StringComparison.CurrentCultureIgnoreCase));


        //string declared = "Intern pool";
        //string built = new StringBuilder("Intern pool").ToString();
        //string interned = System.String.Intern(built);
        //Console.WriteLine(object.ReferenceEquals(declared, built));
        //Console.WriteLine(object.ReferenceEquals(declared, interned));

        //string greetings = "Hello,";
        //string name = " John";
        //string result = greetings + name;
        //result += " How are you doing";
        //Console.WriteLine(result);


        //IndexOf() and LastIndexOf()
        //string book = "Introduction to C# book";
        //int index = book.IndexOf("C#");
        //int lastIndex = book.LastIndexOf("book");
        //Console.WriteLine(index);
        //Console.WriteLine(lastIndex);


        //string quote = "The main intent of the \"Intro C#\"" + " book is to introduce the C# programming to newbies.";
        //string keyword = "C#";
        //int index = quote.IndexOf(keyword);
        //while (index != -1)
        //{
        //    Console.WriteLine("{0} found at index: {1}", keyword, index);
        //    index = quote.IndexOf(keyword, index + 1);
        //}


        //Substring()
        //string path = "My Name Is Lucy";
        //string fileName = path.Substring(3, 4);
        //Console.WriteLine(fileName);


        //Split()
        //string listOfBeers = "Amstel, Heineken, Life, Hero";
        //char[] separators = new char[] { ' ', ',', '.' };
        //string[] beersArr = listOfBeers.Split(separators);
        //foreach (string beer in beersArr)
        //{
        //    if (beer != "")
        //    {
        //        Console.WriteLine(beer);
        //    }
        //}


        //Replace()
        //string details = "ricardo@gmail.com and my email address is ricardo@gmail.com";
        //string replace = details.Replace("ricardo@gmail.com", "ricardo1@gmail.com");
        //Console.WriteLine(replace);


        //Trim()
        //string fileData = " \n\n  Ebuka   ";
        //Console.WriteLine(fileData);
        //Console.WriteLine(fileData.Trim());

        //string fileData = " 111 $ % David Allen ### s ";
        //char[] trimChars = new char[] { ' ', '1', '$', '%', '#', 's' };
        //string reduced = fileData.Trim(trimChars);
        //Console.WriteLine(reduced);

        //string name = "   Ebuka   ";
        //string result = name.Trim();
        //Console.WriteLine(result);


        //string collector = "Numbers: ";
        //for (int index = 1; index <= 20000; index++)
        //{
        //    collector += index;
        //}
        //Console.WriteLine(collector);

        //Room room = new Room();


        //Dictionary<string, string> _store = new();
        //string GenerateOtp(string phoneNumber)
        //{
        //    var otp = new Random().Next(10000, 99999).ToString();
        //    _store[phoneNumber] = otp;
        //    Console.WriteLine($"[Mock OTP] {otp} -> {phoneNumber}");
        //    return otp;
        //}
        //string phone = "08161778965";
        //Console.WriteLine(GenerateOtp(phone));

        //string otp = "49526";
        //Console.WriteLine(VerifyOtp(phone, otp));
        //bool VerifyOtp(string phoneNumber, string otp)
        //{
        //    var value = _store.TryGetValue(phoneNumber, out var result);
        //    if (!value)
        //    {
        //        return false;
        //    }

        //    if (result == otp)
        //    {
        //        var ok = _store.Remove(phoneNumber, out _);
        //        return true;
        //    }
        //    return false;
        //}


        //Reverse string
        //string name = "Ebuka";
        //string reversed = ReverseText(name);
        //Console.WriteLine(reversed);

        //string ReverseText(string text)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    string ch = "comes";
        //    for (int i = text.Length - 1; i >= 0; i--)
        //    {
        //        sb.Append(text[i]);
        //    }
        //    return sb.ToString();
        //}


        //string name = "EbuKaCoMeS";
        //string result = GetCapitalLetters(name);
        //Console.WriteLine(result);

        //string GetCapitalLetters(string name)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        char ch = name[i];
        //        if (char.IsUpper(ch))
        //        {
        //            sb.Append(ch);
        //        }
        //    }
        //    return sb.ToString();
        //}

        //DateTime dateTime = DateTime.Now;
        //Console.WriteLine(dateTime);
        //Console.WriteLine(dateTime.ToString());

        //ConstAndReadOnlyExample instance = new ConstAndReadOnlyExample(50);
        //Console.WriteLine(ConstAndReadOnlyExample.PI);
        //Console.WriteLine(instance.Size);

        //Dogg dogg = new Dogg();
        //Console.WriteLine(dogg.GetAge());
        //Console.WriteLine(dogg.Get());
        //Console.WriteLine(dogg.PrintAge());

        //Console.WriteLine(dogg.Name);
        //dogg.Bark();
        //dogg.DoSomething();

        //Kid kid = new Kid();
        //kid.CallTheDog(dogg);
        //kid.WagTheDog(dogg);

        //Collar collar = new Collar(3);
        //int xValue = collar.GetAndSetX;
        //int yValue = collar.GetAndSetY;
        //int x = collar.GetAndSetX = 5;
        //int y = collar.GetAndSetY = 2;
        //Console.WriteLine("The x value is: {0} and the y value is: {1} ", xValue, yValue);
        //Console.WriteLine("The x value is: {0} and the y value is: {0} ", x, y);
        //collar.PrintSurface();


        //var result = SqrtPreCalculated.GetSqrt(254);
        //Console.WriteLine(result);

        int value = (int)Days.Wednesday;
        Console.WriteLine(value);

        Console.WriteLine("Hello, C# Academy! One more modification");
    }   
}
