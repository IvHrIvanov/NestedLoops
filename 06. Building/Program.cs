using System;
using System.Runtime.Serialization;

namespace _06._Building
{
    class Program
    {
        static void Main()
        {
            int floar = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int room = 0; room < rooms; room++)
            {
                Console.Write($"L{floar}{room} ");

            }
            Console.WriteLine();
            while (floar > 1)
            {               
                if (floar % 2 == 0)
                {
                    floar--;
                    for (int aparRoom = 0; aparRoom < rooms; aparRoom++)
                    {
                        Console.Write($"A{floar}{aparRoom} ");
                    }

                }              
                else if (floar % 2 == 1)
                {
                    floar--;
                    for (int apartRoom = 0; apartRoom < rooms; apartRoom++)
                    {
                        Console.Write($"O{floar}{apartRoom} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
