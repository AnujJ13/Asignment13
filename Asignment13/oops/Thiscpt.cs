using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment13.oops
{
    class Thiscpt
    {
        class Bike
        {
            string Bike_name;
            string modelnumber;

            public Bike() : this("HonDa", "5G")                 // third use of the function
            {
                Console.WriteLine("Default Bike");

            }
            public Bike(string Bike_name, string modelnumber)
            {
                this.Bike_name = Bike_name;                    // first use of the function
                this.modelnumber = modelnumber;
                this.show();                                   // second use of the function


            }
            public void show()
            {
                Console.WriteLine(Bike_name + " " + modelnumber);
            }
        }
        class This123
        {
            static void Main(string[] args)
            {
                Bike b = new Bike();  // this concept

            }
        }
    }
    class loan
    {
        float CalculateLoan(int P, float R, int T)
        {
            float loan;
            return loan = (float)P * R * T;

        }
        float CalculateLoan(int P, float R1, float R2, int T)
        {
            float loan1;
            if (T <= 6)
            {
                return loan1 = (float)P * R1 * T;
            }
            else
            {
                return loan1 = (float)P * R2 * T;

            }
        }
        static void Main(string[] args)
        {
            loan l = new loan();
            Console.WriteLine(l.CalculateLoan(10000, 12F, 3));
            Console.WriteLine(l.CalculateLoan(100000, 2f, 5f, 6));

        }

    }
    class  Oversloadstatic
    {
        static float area(float r)
        {
            return (float)3.14 * r * r;

        }
        static int area(int l, int b)
        {
            return l = b;

        }
        static float area(int b, float h)
        {
            return (float)0.5 * b * h;

        }
        static int area(int s)
        {
            return s * s;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("area of circle:"+area(2.5f));
            Console.WriteLine("area of rectangle:"+area(6,8));
            Console.WriteLine("area of rectangle:" + area(2, 3f));
            Console.WriteLine("area of square:" + area(4));
        }

    }
    class Department
    {
        int Did;
        string name;

        public Department(int Did, string name)
        {
            this.Did = Did;
            this.name = name;
        }
        public void show()
        {
            Console.WriteLine(Did + " " + name);
        }
    }
    class Employee
    {
        int id;
        string name;
        int salary;
        Department dp;

        Employee(int id, string name, int salary, Department dp)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.dp = dp;
        }

        void Display()
        {
            Console.WriteLine(id + "" + name + " " + salary + " " + dp);
            dp.show();
        }
        static void Main(string[] args)
        {
            Department t = new Department(201, "science");
            Employee E;
            E = new Employee(101, "Shankar", 700000, t);
            E.Display();
        }
    }











}   
    
    

        
