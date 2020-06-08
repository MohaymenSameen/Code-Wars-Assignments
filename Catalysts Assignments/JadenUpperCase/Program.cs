using NUnit.Framework;
using System;

namespace JadenUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        public string ToJadenCase(this string phrase)
        {
            string[] sentence = phrase.Split(' ');
            string newPhrase = "";
            foreach (String word in sentence)
            {
                char firstLetter = Char.ToUpper(word[0]);
                newPhrase += firstLetter + word.Substring(1) + " ";
            }
            return newPhrase.Remove(newPhrase.Length - 1, 1);
        }
        public void FixedTest()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real ",
                            "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                            "Strings didn't match.");
        }
    }
}
