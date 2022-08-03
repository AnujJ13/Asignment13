using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment13.oops
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the digit");

            String num = Console.ReadLine();
            int num_of_digit = num.Length - 1;

            int given_number = int.Parse(num);

            double sum_of_1stAndLastnumber = (given_number / (Math.Pow(10, num_of_digit))) + (given_number % 10);



            Console.WriteLine(sum_of_1stAndLastnumber);


        }

    }
    class Amimal
    {
        public int leg_number;
        public string animal_name;
        public string food_type;

        static void Main(string[] args)
        {
            Amimal tiger = new Amimal();
            tiger.animal_name = "Tiger";
            tiger.leg_number = 4;
            tiger.food_type = "otheranimal";

            Console.WriteLine(tiger.food_type + " " + tiger.animal_name + " " + tiger.leg_number);


        }
    }
    class Animal2
    {
        public int legNumber;
        public string animalName;
        public string foodType;

        static void Main(string[] args)
        {
            Animal2 cow = new Animal2();
            cow.animalName = "cow";
            cow.legNumber = 4;
            cow.foodType = "grass";

            Console.WriteLine(cow.foodType + " " + cow.animalName + " " + cow.legNumber);
        }

    }
    class Animal3
    {
        public int leg_number;
        public string animal_name;
        public string food_type;

        public Animal3(int leg_number, string animal_name, string food_type)
        {
            this.leg_number = leg_number;
            this.animal_name = animal_name;
            this.food_type = food_type;
        }

        static void Main(string[] args)
        {
            Amimal dog = new Amimal();
            dog.animal_name = "dog";
            dog.leg_number = 4;
            dog.food_type = "grass";
            Console.WriteLine(dog.food_type + " " + dog.animal_name + " " + dog.leg_number);
        }

    }
    class Car
    {
        public int model_number;
        public string car_name;
        public string car_colour;
        public int car_number;

        static void Main(string[] args)
        {
            Car bmw = new Car();
            bmw.model_number = 1;
            bmw.car_colour = "white";
            bmw.car_number = 13;

            Console.WriteLine(bmw.car_number + " " + bmw.car_colour + " " + bmw.model_number);
        }

    }
    class car2
    {
        public int model_number;
        public string car_name;
        public string car_colour;
        public int car_number;
        static void Main(string[] args)
        {
            Car skoda = new Car();
            skoda.model_number = 12;
            skoda.car_colour = "silver";
            skoda.car_number = 131;
            Console.WriteLine(skoda.car_number + " " + skoda.car_colour + " " + skoda.model_number);
        }
    }
    class Vehicle
    {
        public int model_no;
        public string type;
        public int number_wheel;
        public int average;



        public void AcceptDetails(int emodel, string etype, int ewheels)
        {
            model_no = emodel;
            type = etype;
            number_wheel = ewheels;



        }
        public void Average()
        {
            if (number_wheel == 4)
            {
                Console.WriteLine("Average is 15");
            }
            else if (number_wheel == 2)
            {
                Console.WriteLine("Average is 45");
            }



        }
        public void Display()
        {
            Console.WriteLine(model_no + " " + type + " " + number_wheel);


        }
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.AcceptDetails(101, "Bike", 2);
            v.Display();
            v.Average();




        }

    }
    class Imei
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            long a = long.Parse(Console.ReadLine());
            long sum = 0;
            long n = a;

            while (a > 0)
            {
                long r = a % 10;
                sum = sum + r;
                a = a / 10;

            }
            a = n;
            Console.WriteLine(sum);

            if (sum % 10 == 0)
            {
                Console.WriteLine("correct IMEI number");
            }
            else
            {
                Console.WriteLine("invalid IMEI number");
            }
        }
    }
    class Cardk
    {
        int model_no;
        string name;
        int price;

        public int Model_No
        {
            get { return model_no; }
            set { model_no = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
    class Carinfo
    {
        static void Main(string[] args)
        {
            Cardk c = new Cardk();
            c.Model_No = 13;
            c.Name = "safari";
            c.Price = 100000;
            Console.WriteLine("model_no" + c.Model_No + "name" + c.Name + "price" + c.Price);


        }
    }
    class Area
    {
        int area(int l, int b)
        {
            return (l * b);

        }

        double area(double b, double h)
        {
            return (b * h) / 2;

        }
        int area(int s)
        {
            return (s * s);

        }


        double area(double r)
        {
            return (3.14 * r * r);


        }

        static void Main(string[] args)
        {
            Area a = new Area();
            Console.WriteLine("area of rectangle" + a.area(5, 10));
            Console.WriteLine("area of triangle" + a.area(5.5, 8.5));
            Console.WriteLine("area of square" + a.area(9));
            Console.WriteLine("area of circle" + a.area(2, 2));
        }

    }
    class Calci
    {
        int calci(int x, int y)
        {
            return x + y;

        }

        float calci(float x, float y)
        {
            return x - y;

        }
        double calci(double x, double y)
        {
            return x * y;

        }
        double calci(int x, double y)
        {
            return x % y;

        }
        static void Main(string[] args)
        {
            Calci C = new Calci();
            Console.WriteLine("addition" + C.calci(2, 5));
            Console.WriteLine("subtraction" + C.calci(5, 2));
            Console.WriteLine("mutiplication=" + C.calci(5, 5));
            Console.WriteLine("division" + C.calci(5, 3));


        }

    }
    class Program1
    {
        static int frequencyDigits(long n, int d)
        {

            int count = 0;
            while (n > 0)
            {
                if (n % 10 == d)
                    count++;
                n = n / 10;
            }
            return count;
        }


        static public void Main(String[] args)
        {


            long N = 9922684215;


            int D = 9;
            int D1 = 9;
            int D2 = 2;
            int D3 = 2;
            int D4 = 6;
            int D5 = 8;


            Console.WriteLine("Frequency of digit 9: " + frequencyDigits(N, D));
            Console.WriteLine("Frequency of digit 9: " + frequencyDigits(N, D1));
            Console.WriteLine("Frequency of digit 2: " + frequencyDigits(N, D2));
            Console.WriteLine("Frequency of digit 2: " + frequencyDigits(N, D3));
            Console.WriteLine("Frequency of digit 6: " + frequencyDigits(N, D4));
            Console.WriteLine("Frequency of digit 8: " + frequencyDigits(N, D5));

        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the exponent:");
            int y = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            for (int i = 1; i <= y; i++)
            {
                power = power * x;
            }
            Console.WriteLine("x^y: " + power);
        }

    }
    class Program4
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 5; i++)
            {

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }

    }
    class Ptrn
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = i; k < 5; k++)
                {
                    Console.Write(" ");

                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j % 2);

                }
                Console.WriteLine();
            }

        }

    }
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the n th term:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i * (i + 2) + "");
            }
        }

    }
    class Program6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine("");
            }

        }
    }
    class Onezeronone
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = i; k < 5; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j % 2);


                }
                Console.WriteLine();
            }
        }
    }


}






