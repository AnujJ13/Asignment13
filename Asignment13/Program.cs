using System;

namespace Asignment13
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || ((y % 4 == 0) && (y % 100 != 0)))

                Console.WriteLine("Is Leap year");
            else
                Console.WriteLine("Is not a lea year");
        }
    }
    class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("A number is divisible by 5 and 11 ");
            }
            else
            {
                Console.WriteLine("A number is not divisible by 5 and 11 ");

            }
        }
    }
    class Maximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 1st numbers");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 2nd numbers");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 3rd numbers");
            int num3 = int.Parse(Console.ReadLine());


            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine(" num1 is maximum");
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine(" num2 is maximum");
            }
            else
            {
                Console.WriteLine(" num3 is maximum");
            }
        }
    }
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a charector");
            char cha = char.Parse(Console.ReadLine());
            if ((cha == 'a') || (cha == 'e') || (cha == 'i') || (cha == 'o') || (cha == 'u'))
            {
                Console.WriteLine(" is a vowel");
            }
            else
            {
                Console.WriteLine(" is a consonent");
            }

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
    class AlphabateDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a char");
            char cha = Convert.ToChar(Console.ReadLine());
            if ((cha >= 'a' && cha <= 'z') || (cha >= 'A' && cha <= 'Z'))
            {
                Console.WriteLine("You intered charector ");
            }
            else if ((cha > '0') && (cha <= '9'))
            {
                Console.WriteLine("You intered digit ");
            }
            else
            {
                Console.WriteLine("You intered special char ");
            }


        }

    }
    class PositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("number is negative");
            }
            else
            {
                Console.WriteLine("number is zero");
            }
        }
    }

    class EvenOrOdd
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered number is Even ");
            }
            else
            {
                Console.WriteLine("Entered number is Odd");
            }
        }
    }
    class GrossSalary
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter basic salary ");
            int bs = Convert.ToInt32(Console.ReadLine());
            double grs;
            // double da, hra;

            if (bs <= 10000)
            {
                //da = bs * ( da / 100);
                //hra = bs * (hra / 100);
                //gs = bs + da +   hra;
                grs = bs + bs * (0.8 + 0.2);
                Console.WriteLine("gross salary is " + grs);

            }
            else if (bs <= 20000)
            {
                grs = bs + bs * (0.25 + 0.9);
                Console.WriteLine("gross salary of basic salary  is " + grs);
            }
            else if (bs <= 20000)
            {
                grs = bs + bs * (0.3 + 0.95);
                Console.WriteLine("gross salary inclding da nd hra is " + grs);
            }
        }
    }
    class Week
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" enter number ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tusday");
                    break;
                case 3:
                    Console.WriteLine("wednesday ");
                    break;
                case 4:
                    Console.WriteLine("thursday ");
                    break;
                case 5:
                    Console.WriteLine("friday ");
                    break;
                case 6:
                    Console.WriteLine("saturday ");
                    break;
                case 7:
                    Console.WriteLine("sunday ");
                    break;
                default:
                    Console.WriteLine("invalid ");
                    break;

            }
        }
    }
    class Trangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hight of a trangle");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of a trangle");
            int w = int.Parse(Console.ReadLine());

            float area;
            area = (w * h) / 2;
            Console.WriteLine("area of trangle is " + area);
        }
    }
    class Rectangle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of a rectangle");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of a rectangle");
            int w = int.Parse(Console.ReadLine());

            int a;
            a = len * w;
            Console.WriteLine("The area of rectangle are " + a);
        }
    }
    class CircleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the redious of a circle ");
            int r = int.Parse(Console.ReadLine());

            float a;
            float pi = 3.14f;
            a = pi * r * r;
            Console.WriteLine("are of circle is " + a);
        }
    }
    class SquareArea

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side of a square ");
            int s = int.Parse(Console.ReadLine());
            int a;                     // s is a side of square
            a = s * s;
            Console.WriteLine("Are of a square are " + a);

        }
    }
    class Circumference
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter a redius of circle");
            int r = Convert.ToInt32(Console.ReadLine());

            float a;
            float pi = 3.14f;
            a = 2 * pi * r;
            Console.WriteLine("are of circumference of a circle is " + a);
        }
    }
    class Perimeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a side of perimeter");
            int s = int.Parse(Console.ReadLine());
            int p;  //perimeter
            p = 4 * s;
            Console.WriteLine("Perimeter os a square are " + p);


        }
    }
    class ThreeDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());


            if (num < 1000 && num > 99)
            {
                Console.WriteLine("Entered number is three digit number ");
                int lastdigit = num % 10;
                int Firstdigit = num / 100;
                int sum = lastdigit + Firstdigit;

                Console.WriteLine("Sum of 1st and 3rd digit is:" + sum);

            }
            else
            {
                Console.WriteLine("Not a three digit number");
            }
        }
    }


    class Question5
    {
        public static void Main(string[] args)
        {
            bool YNchoice;
            /*   Console.WriteLine("enter 1st nmber ");
               int num1 = int.Parse(Console.ReadLine());
               Console.WriteLine("enter 2nd nmber ");
               int num2 = int.Parse(Console.ReadLine());*/
            do
            {
                Console.WriteLine("Let me know which area you want to Calculate " +
                    "\n 1. Area of Circle" +
                    " \n 2. Area of Square \n " +
                    "3. Area of Right Angle Triangle" +
                    " \n 4. Area of Rectangle " +
                    "\n 5. Circumference of Circle" +
                    " \n 6. Perimeter of Square");
                Console.WriteLine("Please Enter Your Choise ");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Please give me your Circle's radius value:");
                        int rad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Circle is :" + (22 / 7) * rad * rad);
                        break;
                    case 2:
                        Console.WriteLine("Please give me your Sqare's side value:");
                        int side = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Square : " + side * side);
                        break;
                    case 3:
                        Console.WriteLine("Please give me your  right angle trangle's Base and hight's value:");
                        int bes = int.Parse(Console.ReadLine());
                        int hight = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Right Angle Triangle : " + bes * hight * 0.5);
                        break;
                    case 4:
                        Console.WriteLine("Please give me your  Rectangle's width and Length's value:");
                        int width = int.Parse(Console.ReadLine());
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Rectangle : " + width * length);
                        break;
                    case 5:
                        Console.WriteLine("Please give me your  Circle's radius value:");
                        int radius = int.Parse(Console.ReadLine());
                        Console.WriteLine("Circumference of Circle : " + radius * 44 / 7);
                        break;
                    case 6:
                        Console.WriteLine("Please give me your Square's side value:");
                        int sq_side = int.Parse(Console.ReadLine());
                        Console.WriteLine("Perimeter : " + 4 * sq_side);
                        break;
                    default:
                        Console.WriteLine("OOPS: Sorry You have given Wrong input ");
                        break;
                }

                Console.WriteLine("If you want to calculate more then Please enter: 1");
                Console.WriteLine("If you want to Exit the process then Please enter: 0");

                int yn = int.Parse(Console.ReadLine());



                if (yn == 1)
                    YNchoice = true;
                else
                    YNchoice = false;

            } while (YNchoice);
        }
    }






}
