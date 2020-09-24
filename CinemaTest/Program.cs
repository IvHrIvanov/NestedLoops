using System;

namespace CinemaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTicket = 0;
            int standardTicket = 0;
            int kidTicket = 0;
            bool flag = false;


            while (true)
            {
                string movie = Console.ReadLine();
                int freeSlot = int.Parse(Console.ReadLine());
                
                while (true)
                {
                    double totalTicket = studentTicket + standardTicket + kidTicket;
                    double full = totalTicket * 1.0 / freeSlot * 100;
                    string addTicket = Console.ReadLine();
                    switch (addTicket)
                    {
                        case "student":
                            studentTicket++;
                            break;
                        case "standard":
                            standardTicket++;
                            break;
                        case "kid":
                            kidTicket++;
                            break;
                        case "End":
                            Console.WriteLine($"{movie} - {full:f2}% full.");
                            break;
                        case "Finish":
                            flag = true;
                            break;


                    }
                    if(flag)
                    {
                        
                         double studentPercent = studentTicket * 1.0 / totalTicket * 100;
                        double standardPercent = standardTicket * 1.0 / totalTicket * 100;
                        double kidPercent = kidTicket * 1.0 / totalTicket * 100;
                        Console.WriteLine($"{movie} - {full:f2}% full.");
                        Console.WriteLine($"Total tickets: {totalTicket}");
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
