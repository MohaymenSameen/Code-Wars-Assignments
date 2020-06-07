using System;
using System.Collections.Generic;
using System.IO;

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
            Dictionary<int,int> sales = DailySales("daily.txt");
            Dictionary<int,int> amount = Deposited("deposited.txt");

            Console.ReadKey();
        }
        public List<int> DaysDailySales(Dictionary<int,int> sales, Dictionary<int,int>amount)
        {
            int day = 1;
            List<int> days = new List<int>();

            while (day != 0)
            {
                Console.Write("Enter the day: ");
                day = int.Parse(Console.ReadLine());

                if(day == 0)
                {
                    break;
                }
                Console.Write("Enter the daily sales: ");
                int dailySales = int.Parse(Console.ReadLine());

                Console.Write("Enter the payment in the bank: ");
                int paymentBank = int.Parse(Console.ReadLine());

                if (dailySales > paymentBank)
                {
                    days.Add(day);
                }
            }            
            return days;
        }
        void DisplayDays(List<int> days)
        {
            int count = 1;
            foreach (int day in days)
            {
                Console.WriteLine("{0} => {1} ",count,day);
                count++;
            }
        }
        public Dictionary<int,int> DailySales(string filename)
        {
            Dictionary<int, int> dailySales = new Dictionary<int, int>();
            StreamReader reader = new StreamReader(filename);
            string line = "";
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                string[] words = line.Split(' ');

                int day = Convert.ToInt32(words[1]);
                int sales = Convert.ToInt32(words[2]);

                dailySales.Add(day, sales);               
            }
            reader.Close();
            return dailySales;
        }
        public Dictionary<int, int> Deposited(string filename)
        {
            Dictionary<int, int> dailySales = new Dictionary<int, int>();
            StreamReader reader = new StreamReader(filename);
            string line = "";
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                string[] words = line.Split(' ');

                int day = Convert.ToInt32(words[1]);
                int sales = Convert.ToInt32(words[2]);

                dailySales.Add(day, sales);
            }
            reader.Close();
            return dailySales;
        }        
    }
}
