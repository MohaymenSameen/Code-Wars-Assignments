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
            DontGiveMeFive(4, 17);
            Console.ReadKey();
        }
        public static int DontGiveMeFive(int start, int end)
        {
            return Enumerable.Range(start, end - start + 1).Count(x => !x.ToString().Contains("5"));
        }
    }
}
