using System;
using System.Threading.Channels;

namespace Cinema
{
    class Program
    {
        static void Main()
        {
            int studentTicket = 0;
            int standartTicket = 0;
            int kidTicket = 0;

         

            while (true)
            {
                string movie = Console.ReadLine();
                int freeSlot = int.Parse(Console.ReadLine());
                double totalTicket = studentTicket + standartTicket + kidTicket;
                while (true)
                {
                    double full = totalTicket * 1.0 / freeSlot * 100;
                    string addTicket = Console.ReadLine();
                    switch(addTicket)
                    {
                        case "student":
                            studentTicket++;
                            break;
                        case "standard":
                            standartTicket++;
                            break;
                        case "kid":
                            kidTicket++;
                            break;
                        case "End":
                            Console.WriteLine($"{movie} - {full:f2}% full.");
                            continue;
                            

                    }
                    
                }
            }


        }
    }
}
