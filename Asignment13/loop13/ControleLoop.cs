using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment13.loop13
{
    class EvenNoQ1
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(+i);
                }
            }
        }
    }

    class OddNoQ2
    {
        static void Main(string[] args)
        {
            for (int i = 521; i >= 229; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(+i);
                }
            }
        }
    }

    class BreakQ3
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 7)
                    break;

                Console.WriteLine(+i);
            }
        }
    }
    class AlphabetsQ5
    {
        static void Main(string[] args)
        {
            /* for (char c = 'A'; c <= 'Z'; c++)
             {
                 Console.WriteLine(c);
             }*/

            for (int c = 65; c <= 90; c++)
            {
                Console.WriteLine((char)c);
            }
        }
    }
    class AllEvenNo6
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.WriteLine("Enter a nmber");
            int num = int.Parse(Console.ReadLine());
            for (i = 0; i <= num; i += 2)
            {
                //if (num % 2 = 0)

                sum = sum = i;
                Console.WriteLine(sum);

            }
        }
    }
    class AllOddNoQ7
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.WriteLine("Enter a nmber");
            int num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i += 2)
            {
                //if (num % 2 = 0)

                sum = sum = i;
                Console.WriteLine(sum);

            }
        }
    }

    class CountNoOfDigitQ8
    {
        static void Main(string[] args)
        {
            int num = 0, count = 0;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            // for (int i = 0; i < num; i++)
            while (num != 0)
            {
                //num = num % 10;
                num = num / 10;
                ++count;

            }
            Console.WriteLine(count);

        }
    }

    class ProduuctOfDigitQ9
    {
        static void Main(string[] args)
        {
            int digit, product = 1;
            Console.WriteLine("Enter frist number");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                digit = n % 10;
                product = product * digit;
                n = n / 10;
            }
            Console.WriteLine(product);
        }
    }

    class FrequencyOfDigitQ10

    {
        static void Main(string[] args)
        {
            int p, dig, i;
            int[] a = new int[10];
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            p = num;
            while (p > 0)
            {
                dig = p % 10;
                for (i = 0; i <= 9; i++)
                {
                    if (dig == i)
                    {
                        a[i]++;
                    }

                }
                p = p / 10;
            }
            Console.WriteLine("original number " + num);
            for (i = 0; i <= 9; i++)
            {
                if (a[i] != 0)
                {
                    Console.WriteLine("Frequency of " + i + " is : " + a[i]);
                }
            }
        }
    }

    class PrimeNo11

    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Prime Number's  Are");
            /* Console.WriteLine("Enter a number 
             int num = int.Parse(Console.ReadLine());*/
            for (int num = 300; num <= 400; num++)
            {

                for (int i = 2; i <= (num / 2); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.Write("    " + num);


            }
        }
    }
    class TableQ12

    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * num);
            }
        }
    }
    class Squares13
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i * i);
            }
        }
    }
    class Power14
    {
        static void Main(string[] args)
        {
            long result = 1;
            Console.WriteLine("Enter a base valu");
            long b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter a index valu");
            long index = Convert.ToInt64(Console.ReadLine());
            while (index != 0)
            {
                result = result * b;
                --index;
            }
            Console.WriteLine("Power is " + result);
        }
    }
}


