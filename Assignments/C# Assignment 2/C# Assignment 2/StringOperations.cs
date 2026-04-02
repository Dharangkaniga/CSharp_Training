using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_2
{
    internal class StringOperations
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Word1: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter a Word2: ");
            string word2 = Console.ReadLine();
            Console.WriteLine(" ");
            Length(word1);
            Reverse(word1);
            Compare(word1, word2);
        }
        public static void Length(string word)
        {
            Console.WriteLine($"Length Of Word: {word}");
            Console.WriteLine(" ");

        }
        public static void Reverse(string word) 
        {
            string reverse = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
            Console.WriteLine($"Reversed word: {reverse}");
            Console.WriteLine(" ");

        }
        public static void Compare(string w1, string w2)
        {
            if(w1==w2)
            {
                Console.WriteLine("Both Words are Equal");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine(" Both Words are Not Equal");
                Console.WriteLine(" ");
            }

        }
    }
}
