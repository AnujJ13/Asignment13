using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment13.oops
{
    class car
    {
        public int model;
        private int mode1;
        public string name;
        public int price;

        static void Main(string[] args)
        {
            car car1 = new car();

            car1.model = 111;
            car1.name = "tiago";
            car1.price = 500000;
            car car2 = new car();

            car2.mode1 = 112;
            car2.name = "kia";
            car2.price = 700000;

            Console.WriteLine(car1.mode1 + " " + car1.name + " " + car1.price);
            Console.WriteLine(car2.mode1 + " " + car2.name + " " + car2.price);

        }
    }
    class stundentpercentage
    {
        public int id;
        public string name;
        public int m1marks, m2marks, m3marks;
        public int total;
        public int percentage;


        public void AcceptDetailS(int sid, string sname, int smarks, int sm2marks, int sm3marks)
        {
            id = sid;
            name = sname;
            m1marks = smarks;
            m2marks = sm2marks;
            m3marks = sm3marks;

        }
        public void calculate()
        {
            total = m1marks + m2marks + m3marks;
            percentage = (total = 100) / 3;


        }
        public void Display()

        {
            Console.WriteLine(id + "" + name + "" + m1marks + " " + m3marks);
            Console.WriteLine(total + " " + percentage);

        }



    }
    class Shopping
    {
        string item;
        int quantity;
        int price;
        int total_bill;

        public void Accept(string item, int quantity, int price)
        {
            this.item = item;
            this.quantity = quantity;
            this.price = price;

            if (this.quantity <= 0)
            {
                Console.WriteLine("error");

            }
            else
            {
                total_bill = this.Getbill();
                this.Display();
            }
        }
        public int Getbill()
        {
            return price * quantity;

        }
        public void Display()
        {
            Console.WriteLine("item" + item);
            Console.WriteLine("quantity" + quantity);
            Console.WriteLine("price" + price);
            Console.WriteLine("Total Bill" + total_bill);

        }
        static void Main(string[] args)
        {
            Shopping obj = new Shopping();
            obj.Accept("shirt", 6, 850);
            obj.Display();
            //obj.Getbill();


        }

    }
    class student_percentage
    {
        int id;
        string name;
        float percentage;
        char studgrade;
        public void Accept(int id, string name, float percentage)
        {
            this.id = id;
            this.name = name;
            this.percentage = percentage;
        }
        public void Grade()
        {

            if (percentage > 90)
            {
                studgrade = 'A';

            }
            else if (percentage > 80)
            {

                studgrade = 'B';
            }
            else if (percentage > 50)
            {
                studgrade = 'C';
            }
            else
            {
                studgrade = 'F';
            }

        }
        public void Display()

        {
            Console.WriteLine("student detail");
            if (percentage < 0)
            {
                Console.WriteLine("error");

            }
            else
            {
                Console.WriteLine("percentage" + percentage + "studgrade" + studgrade);
            }
            Console.WriteLine("id" + id + "name" + name + "percentage" + percentage);

        }

        static void Main(string[] args)
        {
            student_percentage s = new student_percentage();
            s.Accept(101, "ria", 70);
            s.Grade();
            s.Display();




        }
    }
    class Bank
    {
        long accountnumber;
        string customername;
        int balance;

        int total;


        public void Accept(long accountnumber, string customername, int balance)
        {
            this.accountnumber = accountnumber;
            this.customername = customername;
            this.balance = balance;
        }
        public void Display()
        {
            Console.WriteLine("account number" + accountnumber);
            Console.WriteLine("customer name" + customername);
            Console.WriteLine("balance" + balance);

        }
        public void Amountwithdraw()
        {
            Console.WriteLine("Enter withdrawamount");
            int withdrawamount = int.Parse(Console.ReadLine());
            if (balance <= withdrawamount)
            {
                Console.WriteLine("error");
            }
            else
            {
                total = balance - withdrawamount;
                Console.WriteLine(" withdraw successful total " + total);
            }
            // this.Deposit();

        }
        public void Deposit()
        {
            Console.WriteLine("enter the deposit ammount");
            int depositamount = int.Parse(Console.ReadLine());

            total = balance + depositamount;
            Console.WriteLine("Total " + total);
        }
        static void Main(string[] args)
        {
            Bank s = new Bank();
            s.Accept(6178996, "priya", 500000);
            s.Display();
            s.Amountwithdraw();
            s.Deposit();
        }
    }
    class Student1
    {
        int id;
        string name;
        float percentage;
        bool Placement_status;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name

        {
            get { return name; }
            set { name = value; }
        }
        public float Percentage1

        {
            get { return percentage; }
            set { percentage = value; }


        }
        public bool placemetstatus
        {
            get { return Placement_status; }

        }



    }
    class patern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
    class abc
    {
        static void Main(string[] args)
        {
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class plus
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3 || j == 3)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }
    }
    class onezero
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 2 )
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class onetwothreefour
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }

        }
    }
}
      