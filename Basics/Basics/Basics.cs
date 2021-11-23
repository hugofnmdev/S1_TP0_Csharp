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
            double res;
            switch (n)
            {
                case >0:
                    res = Pow(x, n - 1) * x;
                    Console.WriteLine(res);
                    return res;
                case <0:
                    res = Pow(x, n + 1) / x;
                    Console.WriteLine(res);
                    return res;
                case 0:
                    Console.WriteLine(1);
                    return 1;
            }
        }

        public static uint Factorial(uint n)
        {
            uint res;
            switch (n)
            {
                case >0:
                    res = Factorial(n - 1) * n;
                    Console.WriteLine(res);
                    return res;
                default:
                    res = 1;
                    Console.WriteLine(res);
                    return res;
            }
        }
        
        public static bool Prime(uint n, uint i)
        {
            if (i == 1)
            {
                return true;
            }
            else
            {
                if (n % i==0) 
                {
                    return false;
                }
                else
                {
                    return Prime(n, (i - 1));
                }
                    
            }
        }
            
        

        public static bool IsPrime(uint n)
        {
            Console.WriteLine(Prime(n, n/2));
            return Prime(n, 2);
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
            string res = "";
            switch (n)
            {
                case 1:
                    res = "1";
                    Console.Write("1 ");
                    return res;
                case >1 when n%3==0:
                    if (n % 15 == 0)
                    {
                        res = "Sherlock Holmes " + SherlockHolmes(n-1);
                        Console.Write("Sherlock Holmes ");
                        return res;
                    }
                    else
                    {
                        res = "Sherlock " + SherlockHolmes(n-1);
                        Console.Write("Sherlock ");
                        return res;   
                    }
                case >1 when n % 5 == 0:
                    if (n % 15 == 0)
                    {
                        res = "Sherlock Holmes " + SherlockHolmes(n-1);
                        Console.Write("Sherlock Holmes ");
                        return res;
                    }
                    else
                    {
                        res = "Holmes " + SherlockHolmes(n-1);
                        Console.Write("Holmes ");
                        return res;   
                    }
                case 0:
                    res = "";
                    return res;
                default:
                    res = n + SherlockHolmes(n-1);
                    Console.Write(n + " ");
                    return res;;
            }
        }
    }
}