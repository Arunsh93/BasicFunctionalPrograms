using System;

namespace CalculatePowerOfTwo
{
    class UC3_PowerOfTwo
    {
        static void Main(string[] args)
        {
            double power = 0;
            Console.WriteLine("Enter the Number to calculate Power of Two");
            int number = int.Parse(Console.ReadLine());
            
            for(int i = 0; i <= number; i++)
            {
                if(number<31)
                {
                    power = Math.Pow(2, number);
                }
                else
                {
                    Console.WriteLine("Over Flow");
                }
            }

            Console.WriteLine(power);
        }
    }
}
