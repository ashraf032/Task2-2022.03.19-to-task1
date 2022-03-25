using System;

namespace hesap19
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Bir dord reqemli eded daxil edin");
                Console.WriteLine("------------------");

                string num = Console.ReadLine();

                int a = int.Parse(num);
                int b = 7;

                if (a >= 1000 && a <= 10000)

                {

                    Console.WriteLine("Neticeniz");

                    Console.WriteLine("----------");

                    Console.WriteLine($"7{a}8");
                }

                else
                {
                    Console.WriteLine("-----------------------");


                    Console.WriteLine("Bu hal nezere alinmayib");
                }
            }
        }

    }
}