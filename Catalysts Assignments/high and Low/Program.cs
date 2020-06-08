using System;
using System.Linq;
namespace high_and_Low
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
            HighAndLow("6 7 5 2 6 73 0 9 -1");
            Console.ReadKey();
        }
        void HighAndLow(string numbers)
        {
            string[] number = numbers.Split(' ');

            foreach (String num in number)
            {
                int newNum = int.Parse(num);
                Console.WriteLine(newNum);
            }
           // return string.Format(maxValue.ToString() + " " + minValue.ToString());
        }
    }
}
