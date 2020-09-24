using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)

        {
            for (int number = 1; number <= 10; number++)
            {
                for(int nextNumbre = 1; nextNumbre<=10;nextNumbre++)
                {
                    int result = number * nextNumbre;
                    Console.WriteLine($"{number} * {nextNumbre} = {result}");
                }
            }
        }
    }
}
