using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment13.HMW2
{
    class Printx

    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)

                if (i % 5 == 0)
                {

                }

                else
                    Console.WriteLine(i);


        }
        class Loop1
        {
            static void Main(String[] args)
            {
                int b = 0;
                do
                {
                    int a = 2;
                    b++;
                    Console.WriteLine(a++);
                }
                while (b != 3);



            }
        }
        class spy
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the input");
                int input = int.Parse(Console.ReadLine());
                int digit; int sum = 0; int product = 1;
                while (input > 0)
                {
                    digit = input % 10;
                    sum = sum + digit;
                    product = product * digit;
                    input = input / 10;

                }
                Console.WriteLine("sum of number + sum");
                Console.WriteLine("product of number" + product);
                if (sum == product)
                {
                    Console.WriteLine("input is spy number");

                }
                else
                {
                    Console.WriteLine("input is not spy number");

                }

            }
        }
        class Class5
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number");
                int n = int.Parse(Console.ReadLine());
                int cube = n * n * n;
                int a = 1;
                while (n != 0)
                {
                    if (n % 10 != cube % 10)
                    {
                        a = 0;

                    }
                    n = n / 10;
                    cube = cube / 10;

                }
                if (a == 1)
                {
                    Console.WriteLine("Triomorphic");
                }
                else
                {
                    Console.WriteLine("Not Triomorphic");
                }
            }
        }
    }
    class series
    {
        private static int j;

        static void Main(string[] args)
        {
            for (int j = 1; j < 10; j++) ;
            {
                int n = (j * j) + (j * j * j);


                Console.WriteLine(n);
            }
        }
    }
    class Print1
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 50; i++)
            {
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }

        }
    }
    class loop
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {

                int a = 2;
                b++;

                Console.WriteLine(a++);

            }
            while (b != 3);



        }
    }
    class predicto
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryint = 100;
                mysteryint -= i;
                Console.WriteLine(mysteryint);
            }

        }

    }
    class Twin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number");
            int num2 = int.Parse(Console.ReadLine());
            bool prime = true;
            for (int i = 2; i < num1; i++)
            {
                if (num1 % 1 == 0 && num2 % 1 == 0)
                {
                    prime = false;

                }
            }
            if (prime == false)
            {
                Console.WriteLine("prime");

            }
            else
            {
                Console.WriteLine("not prime");

            }




        }
    }
    class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int num2 = int.Parse(Console.ReadLine());

            int a = 0;
            for (int i = 2; i < num1; i++)
            {
                for (int j = 2; j < num2; j++)
                {
                    if (num1 % 1 == 0 && num2 % 1 == 0)
                    {
                        a = 1;
                    }

                }

            }
            if (a == 1)
            {
                if (num1 - num2 == 2 || num2 - num1 == 2)
                {
                    Console.WriteLine("Twin prime");
                }
                else
                {
                    Console.WriteLine("Not twin prime");
                }

            }

        }
    }
    class Class11
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int a = (i * i) + (i * i * i);
                Console.WriteLine(a);
            }
        }
    }
    class Class12
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i * i);
                }
            }
        }
    }
    class Q13
    {

        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;

                        {

                        }
                        j++;

                        Console.WriteLine(i);
                    }

                    



                }
            }
        }
    }
    class q14
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                    c = i;
                else
                {
                    c = a + b;
                    a = b;
                    b = c;

                }
                Console.WriteLine(c + " ");

            }
        }
    }

}








































