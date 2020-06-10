using System;
using System.Linq;

namespace Persistent_bugger
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
            Persistence(39);
            Console.ReadKey();
        }
        public static int Persistence(long n)
        {       
            //still needs to be completed
            string num = Convert.ToString(n);
            
            if (num.Length == 1)
            {
                return 0;
            }
            int count = 0;
            int multiply = 1;
            for (int i = 0; i < num.Length; i++)
            {
                multiply *= num[i];
                //Console.WriteLine(multiply);
            }
            var result = num.ToArray().Select(x => int.Parse(x.ToString())).Aggregate((a, b) => a * b);
            Console.WriteLine(result);
            return multiply;
        }
    }
}
