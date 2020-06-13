using System;
using System.Collections.Generic;
using System.Linq;

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
            DontGiveMeFive(1, 9);
            Console.ReadKey();
        }
        public static int DontGiveMeFive(int start, int end)
        {
            int count = 0;
            for (int i = start; i < end; i++)
            {
                if (!i.ToString().Contains("5"))
                {
                    count++;
                }
                Console.WriteLine(count);
            }
            return Enumerable.Range(start, end - start + 1).Count(x => !x.ToString().Contains("5"));
        }
    }
}
