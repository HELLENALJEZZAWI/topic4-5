using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic4_5
{
    internal class task22
    {
     

class Program
    {
        static int CountWords(string sentence)
        {
            int wordCount = 0;
            bool inWord = false;

            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    // Inside a word
                    inWord = true;
                }
                else if (inWord)
                {
                    // Reached the end of a word
                    wordCount++;
                    inWord = false;
                }
            }

            // If the sentence ends with a word, count it
            if (inWord)
            {
                wordCount++;
            }

            return wordCount;
        }

        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string inputSentence = Console.ReadLine();

            int numberOfWords = CountWords(inputSentence);
            Console.WriteLine($"Number of words: {numberOfWords}");
        }
    }

}
}
