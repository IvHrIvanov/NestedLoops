using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main()
        {



            string movie = Console.ReadLine();
            int freeSlot = int.Parse(Console.ReadLine());

            
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
           
            while (true)
            {
                string slot = Console.ReadLine();
                if (slot == "End")
                {
                    continue;
                }
                else if (slot == "Finish")
                {
                    break;
                }
               
                else if (slot == "student")
                {
                    studentTickets++;
                }
                else if (slot == "standard")
                {
                    standardTickets++;
                }
                else if (slot == "kid")
                {
                    kidTickets++;
                }            

            }
            double totalTickets = standardTickets + studentTickets + kidTickets;

            double full = totalTickets * 1.0 / freeSlot * 100;

            Console.WriteLine($"{movie} - {full:f2}% full.");
          
                double studentPercent = studentTickets * 1.0 / totalTickets * 100;
                double standardPercent = standardTickets * 1.0 / totalTickets * 100;
                double kidPercent = kidTickets * 1.0 / totalTickets * 100;
                Console.WriteLine($"{movie} - {full:f2}% full.");
                Console.WriteLine($"Total tickets: {totalTickets}");
                Console.WriteLine($"{studentPercent:f2}% student tickets.");
                Console.WriteLine($"{standardPercent:f2}% standard tickets.");
                Console.WriteLine($"{kidPercent:f2}% kids tickets.");
               
            




        }
    }
}

