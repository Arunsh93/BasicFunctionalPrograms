using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0.0;
            Console.WriteLine("Enter the Value For Harmonic");
            int number = int.Parse(Console.ReadLine());
            for(int i =0; i<=number; i++)
            {
                result += 1 / (float)i;
                Console.WriteLine("1/{0} + ", i);
            }

            Console.WriteLine($"={result}");
        }
    }
}
