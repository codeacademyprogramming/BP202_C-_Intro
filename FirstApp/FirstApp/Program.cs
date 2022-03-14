using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var sentence = "Hello " + name;
            sentence = "fdf";
            var yearlyProfitOfProduct = 50000;
            var YearlyProfitOfProduct = 455;
            var yearly_profit_of_products = 455;
            //var yearly-profit-of-yearly_profit_of_products = 45;
            var _yearly = 45m;

            byte age;
            age = 45;
            char letter = 'A';
            string letters = "ABCD";

            Console.WriteLine("chars count: " + letters.Length);

            var result = 5 + age;

            bool check = result > 100 || result < 60;


            Console.WriteLine(check);


            if (result > 100)
            {
                Console.WriteLine("Netice 100-den boyukdur!");
            }
            else if (result > 80)
            {
                Console.WriteLine("Netice 80 ve 100 araligindadir");
            }
            else if (result > 50)
            {
                Console.WriteLine("Netice 50 ve 80 araligindadir");
            }
            else
            {
                Console.WriteLine("Netice 50-den boyuk deyil!");
            }


            if (result > 100)
            {
                Console.WriteLine("Netice 100-den boyukdur");
            }
            else
            {
                if (result > 80)
                {
                    Console.WriteLine("Netice 80 ve 100 araligindadir");
                }
                else
                {
                    if (result > 50) 
                    {
                        Console.WriteLine("Netice 50 ve 80 araligindadir");
                    }
                    else
                    {
                        Console.WriteLine("Netice 50-den boyuk deyil!");
                    }

                }
            }


            int dayOfWeek = 10;

            if(dayOfWeek == 1)
                 Console.WriteLine("Bazar ertesi");
            else if(dayOfWeek == 2)
                Console.WriteLine("Cersenbe axsami");
            else if(dayOfWeek == 3) 
                Console.WriteLine("Cersenbe");
            else
                Console.WriteLine("1,2 ve 3-cu gunler deyil!");

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Bazar ertesi");
                    break;
                case 2:
                    Console.WriteLine("Cersenbe axsami");
                    break;
                case 3:
                    Console.WriteLine("Cersenbe");
                    break;
                case 4:
                    Console.WriteLine("Cume axsami");
                    break;
                case 5:
                    Console.WriteLine("Cume");
                    break;
                case 6:
                    Console.WriteLine("Senbe");
                    break;
                case 7:
                    Console.WriteLine("Bazar");
                    break;
                default:
                    Console.WriteLine("Gonderilmis deyer hefte gunu deyil!");
                    break;
            }


            Console.WriteLine("Ededler");
            for (int i = 0; i < 100; i++)
            {
               
            }


            string newName;

            do
            {
                newName = Console.ReadLine();

            } while (newName.Length > 5);

            int number = 10;

            while (number%3!=0)
            {
                number++;
            }


            int[] numbers = new int[3];

            numbers[0] = 10;
            numbers[1] = 45;
            numbers[2] = -98;

            int[] newNumbers = new int[3] {45,-10,-98};

            newNumbers[0] = -10;
            newNumbers[1] = 35;
            newNumbers[2] = -98;

            int[] lastNumbers = { 45, 10, -6 ,10};

            string[] names = { "Hikmet", "Abbas", "Zeyneb" };
            string[] newNames = new string[4];

            Console.WriteLine("last Numbers");
            int sum = 0;
            foreach (int elcin in lastNumbers)
            {
                sum += elcin;
                Console.WriteLine(elcin);
            }

            Console.WriteLine("Result: "+sum);

            Console.WriteLine("last Numbers");
            for (int i = 0; i < lastNumbers.Length; i++)
            {
                Console.WriteLine(lastNumbers[i]);
            }


            Console.WriteLine("Salam "+newName);
        }
    }
}
