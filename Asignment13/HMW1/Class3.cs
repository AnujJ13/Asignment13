using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment13.HMW
{
    class Areaofeqtriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the  length of the side");
            int s = int.Parse(Console.ReadLine());
            double area = 0.866 * s * s;
            Console.WriteLine(area);

        }
    }
    class Marks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the physics");
            int ph = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the chemistry");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the biology");
            int bi = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the math");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the english");
            int en = int.Parse(Console.ReadLine());
            int totalmarks = (ph + ch + bi + m + en);
            double Average = (totalmarks / 5);
            double percentage = ((totalmarks * 100) / 500);
            Console.WriteLine("Average: " + Average);
            Console.WriteLine("parcentage: " + percentage + "%");
            Console.WriteLine("Total marks are: " + totalmarks);


        }

    }
    class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int i = int.Parse(Console.ReadLine());
            if ((i % 400 == 0) || ((i % 4 == 0) && (i % 100! == 0)))

                Console.WriteLine("it is the leap year");

            else
                Console.WriteLine("it is not the leap year");
        }
    }
    class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numer");
            int num = int.Parse(Console.ReadLine());
            if ((num % 5) == 0 && (num % 11 == 0))

                Console.WriteLine("the number is divisible");
            else

                Console.WriteLine("the number is not divisible");




        }
    }
    class Maximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the  first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
                Console.WriteLine("irst number is greater");
            else if
                (num2 > num1 && num2 > num3)
                Console.WriteLine("second number is greater");
            else
                Console.WriteLine("third number is greater");


        }
    }
    class Alphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the alphabet");
            char ch = char.Parse(Console.ReadLine());
            if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u'))

                Console.WriteLine("it is an vovwel");
            else
                Console.WriteLine("it is constant");



        }

    }
    class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter 1st nmber ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd nmber ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("arithmatics operations are \n 1. addition \n 2. subtraction \n 3. multiplication \n 4 division \n");
            Console.WriteLine("enter choise ");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine("addition of two number is :" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("subtraction of two nmber is : " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("multiplicatioon of two nmber is " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("division of two nmber is " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("envalid nmber ");
                    break;
            }


        }

    }
    class Evenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 ==0)
            {
                Console.WriteLine("it is the even number");

            }
            else
            {
                Console.WriteLine("it is the  odd number");
            }

        }
    }
    class Aldgsp
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter the charater");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch > 'a' && ch < 'z')

            {
                Console.WriteLine("it is an alphabet");

            }
            else if (ch > 'A' && ch < 'Z')
            {
                Console.WriteLine("it is an alphabet");
            }
            else
                Console.WriteLine("it is the special charater");

        }
    }

}  
