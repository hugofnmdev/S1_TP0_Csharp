using System;
using System.Security;
using Microsoft.VisualBasic;

namespace Basics
{
    public class Basics
    {
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World !");
        }

        public static void Welcome()
        {
            Console.WriteLine("Hello, what's your name ?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to 221B Baker Street, " + name + "!");
        }

        public static void ComputeAge()
        {

            Console.WriteLine("What's your year of birth ?");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Looks like you're around " + (2021 - year) + " !");
        }

        public static double Pow(double x, int n)
        {
            double res = 1;
            switch (n)
            {
                case >0:
                    res = Pow(x, n - 1) * x;
                    return res;
                    break;
                case <0:
                    res = Pow(x, n - 1) / x;
                    return res;
                    break;
                case 0:
                    return res;
                    Console.WriteLine(res);       
            }
        }

        public static uint Factorial(uint n)
        {
            uint res = n;
            for (uint i = 0; i == n; i++)
            {
                res = res * (n - 1);
                return res;
            }
            Console.WriteLine(res);
            return res;
        }
        
        public static bool IsPrime(uint n)
        {
            if (n == 1 || n == 0)
            {
                Console.WriteLine(false);
                return false;
            }
            else
            {
                for (int a = 2; a <= n / 2; a++)
                {
                    if (n % a == 0)
                    {
                        Console.WriteLine(false);
                        return false;
                    }

                }
                Console.WriteLine(true); 
                return true;
            }
        }

        public static uint Fibonacci(uint n)
        {
            uint res = 0;
            switch (n)
            {
                case 0 :
                    res = 0;
                    break;
                case 1 :
                case 2 :
                    res = 1;
                    break;
                default :
                    res = (Fibonacci( n - 1)) + (Fibonacci(n - 2));
                    break;
            }
            Console.WriteLine(res);
            return res;
        }

        public static string SherlockHolmes(uint n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Sherlock");
                    return "Sherlock";
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Holmes");
                    return "Holmes";
                }
            }

            return "HEllo";
        }
    }
}