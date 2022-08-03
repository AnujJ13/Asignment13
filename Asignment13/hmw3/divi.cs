using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment13.hmw3
{
    class divi
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
                if (i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num, x;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();

        }
    }
    class wap
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

                    Console.WriteLine(i * i);
                }
            }
        }
    }
    class Program13
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any positive number : ");

            int inputNumber = Convert.ToInt32(Console.ReadLine());

            checkForHarshad(inputNumber);
        }
        private static void checkForHarshad(int inputNumber)
        {

            int copyOfInputNumber = inputNumber;

            int sum = 0;

            int lastDigit = 0;


            while (inputNumber != 0)
            {
                lastDigit = inputNumber % 10;

                sum = sum + lastDigit;

                inputNumber = inputNumber / 10;
            }

           

            if ((copyOfInputNumber % sum) == 0)
            {
                Console.WriteLine(copyOfInputNumber + " is a Harshad number");
            }
            else
            {
                Console.WriteLine(copyOfInputNumber + " is not a Harshad number");
            }
        }
    }
    class q6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("blue");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }






        }
    }
    class Classorder
    {
        int order_id;
        string city;
        string name;
        bool isdeliverd;
        public int Order
        {
            get { return order_id; }
            set { order_id = value; }
        }
        public string CITY
        {
            get { return city; }
            set { city = value; }
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public bool Status
        {

            get { return isdeliverd; }
            set { isdeliverd = value; }
        }
    }
    class classinfo
    {
        static void Main(string[] args)
        {
            Classorder c = new Classorder();
            c.Order = 101;
            c.CITY = "MUMBAI";
            c.NAME = "AMOL";
            c.Status = true;
            Console.WriteLine(c.Order);
            Console.WriteLine(c.CITY);
            Console.WriteLine(c.NAME);
            Console.WriteLine(c.Status);


        }
    }
}








