using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int standartTicket = 0;
            int studentTicket = 0;
            int kidTicket = 0;           
            while (true)
            {
                string movie = Console.ReadLine();
                int freeSpot = int.Parse(Console.ReadLine());
                while (true)
                {

                    double totalTickets = standartTicket + studentTicket + kidTicket;
                    double full = totalTickets * 1.0 / freeSpot * 100;
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "standard":
                            standartTicket++;
                            break;
                        case "student":
                            studentTicket++;
                            break;
                        case "kid":
                            kidTicket++;
                            break;
                    }
                    if (input == "End")
                    {
                        Console.WriteLine($"{movie} - {full:f2}% full.");
                        break;
                    }
                    if (input == "Finish")
                    {
                        double studentPercent = studentTicket * 1.0 / totalTickets * 100;
                        double standardPercent = standartTicket * 1.0 / totalTickets * 100;
                        double kidPercent = kidTicket * 1.0 / totalTickets * 100;
                        Console.WriteLine($"{movie} - {full/2:f2}% full.");
                        Console.WriteLine($"Total tickets: {totalTickets}");
                        Console.WriteLine($"{studentPercent:f2}% student tickets.");
                        Console.WriteLine($"{standardPercent:f2}% standard tickets.");
                        Console.WriteLine($"{kidPercent:f2}% kids tickets.");
                        break;

                    }                   
                }
            }
        }
    }
}

