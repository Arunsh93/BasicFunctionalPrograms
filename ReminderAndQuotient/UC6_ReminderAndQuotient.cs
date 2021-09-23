using System;

namespace ReminderAndQuotient
{
    class UC6_ReminderAndQuotient
    {
        static void Main(string[] args)
        {
            int Dividend = 0;
            int Divisor = 0;
            
            Console.Write("Enter the Dividend: ");
            Dividend = int.Parse(Console.ReadLine());

            Console.Write("Enter the Divisor: ");
            Divisor = int.Parse(Console.ReadLine());

            int Quotient = Dividend / Divisor;
            int Reminder = Dividend % Divisor;

            Console.WriteLine("Dividend:{0} Divisor{1}", Dividend, Divisor);
            Console.WriteLine("Quotient: " + Quotient);
            Console.WriteLine("Reminder: " + Reminder);
        }
    }
}
