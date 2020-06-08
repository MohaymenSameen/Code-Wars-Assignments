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
            /* Good Solution             
             * public static string HighAndLow(string numbers)
                {
                var parsed = numbers.Split().Select(int.Parse);
                return parsed.Max() + " " + parsed.Min();
                }
            */
            HighAndLow("6 7 5 2 6 73 0 9 -1");
            Console.ReadKey();
        }
        string HighAndLow(string numbers)
        {
            string[] number = numbers.Split(' ');
            int[] numArray = new int[number.Length];
            int count = 0;
            foreach (String num in number)
            {
                int newNum = int.Parse(num);
                numArray[count] += newNum;
                count++;
            }
            int maxValue = numArray.Max();
            int minValue = numArray.Min();

            return string.Format(maxValue.ToString() + " " + minValue.ToString());
        }
    }
}
