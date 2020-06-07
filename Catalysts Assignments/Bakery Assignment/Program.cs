using System;

namespace Bakery_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }
        void Start()
        {
            DaysDailySales();
            Console.ReadKey();
        }
        public int DaysDailySales()
        {
            int day = 1;
            int count = 0;

            while (day != 0)
            {
                Console.Write("Enter the day: ");
                day = int.Parse(Console.ReadLine());

                Console.Write("Enter the daily sales: ");
                int dailySales = int.Parse(Console.ReadLine());

                Console.Write("Enter the payment in the bank: ");
                int paymentBank = int.Parse(Console.ReadLine());

                if (dailySales > paymentBank)
                {
                    count++;
                }
            }
            Console.WriteLine("Days where daily sales were more than payment in bank: " + count);
            return count;
        }
    }
}
