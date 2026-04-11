using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment__7
{
    internal class program2
    {
        public static void Main()
        {
            string[] words = { "mum","amsterdam","bloom","Hello","anagram" };

            var result = words
                .Where(w => w.StartsWith("a") && w.EndsWith("m"));

            Console.WriteLine(" Words Start with a and Ends with m ");
            foreach (var word in result)
            {
                Console.WriteLine($" Words: {word}");
            }
        }
    }
}
