using System;
using System.Collections.Generic;

namespace Dont_Give_Me_Five_
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
            DontGiveMeFive(4, 17);
            Console.ReadKey();
        }
        public static int DontGiveMeFive(int start, int end)
        {
            int count = start;

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(count);
                count++;

                string numbers = count.ToString();

                
                Console.WriteLine(numbers);
            }
            return count;
        }
    }
}
