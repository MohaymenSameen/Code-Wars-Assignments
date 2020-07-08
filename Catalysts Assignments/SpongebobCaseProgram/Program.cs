using System;

namespace SpongebobCaseProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Console.Write("Enter your sentence: ");
            string sentence = Console.ReadLine();
            inputSentence(sentence);
            Console.ReadKey();
        }
        public string inputSentence(string sentence)
        {
            int count = 0;
            string newSentence = "";
            foreach (char c in sentence)
            {
                if (count%2==0)
                {
                    newSentence += Char.ToUpper(c);                    
                }
                else
                {
                    newSentence += Char.ToLower(c);
                }
                count++;
            }
            Console.WriteLine(newSentence);

            return sentence;
        }        
    }
}
