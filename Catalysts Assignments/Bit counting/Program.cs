using System;

namespace Bit_counting
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
            CountBits(1234);
            Console.ReadKey();
        }
        public static int CountBits(int n)
        {
            string binary = Convert.ToString(n, 2);            
            int count = 0;

            foreach (Char num in binary)
            {
                count += num-48;
                Console.WriteLine(count);
            }
            

            return count;
        }
    }
}
