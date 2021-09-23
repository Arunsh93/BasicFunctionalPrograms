using System;

namespace SwapOfTwoNumbers
{
    class UC7_SwapOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int FirstNumber = 0;
            int SecondNumber = 0;
            int temp = 0;
            Console.Write("Enter First Number: ");
            FirstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            SecondNumber = int.Parse(Console.ReadLine());

            temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = temp;

            Console.WriteLine("\nAfter Swapping : ");
            Console.WriteLine("\nFirst Number : " + FirstNumber);
            Console.WriteLine("Second Number : " + SecondNumber);
        }
    }
}
