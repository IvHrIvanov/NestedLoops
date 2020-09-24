using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startSpace = int.Parse(Console.ReadLine());
            int endSpace = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combination = 0;
            bool flag = false;
            for (int firstNumber = startSpace; firstNumber <= endSpace; firstNumber++)
            {

                for (int secondNumber = startSpace; secondNumber <= endSpace; secondNumber++)
                {
                    combination++;
                    int sum = secondNumber + firstNumber;
                    if (magicNumber == sum)
                    {
                        Console.WriteLine($"Combination N:{combination} ({firstNumber} + {secondNumber} = {magicNumber})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if(!flag)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
