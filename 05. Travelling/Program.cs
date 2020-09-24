using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                double money = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < money)
                {
                    double addMoney = double.Parse(Console.ReadLine());
                    savedMoney += addMoney;
                }
                Console.WriteLine($"Goin to {input}!");
            }

        }
    }
}
