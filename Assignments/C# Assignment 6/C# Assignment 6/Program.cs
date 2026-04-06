using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteStream();
            CountLines();
        }
        public static void WriteStream()
        {
            using(FileStream fs = new FileStream("StringLines.txt", FileMode.Create, FileAccess.Write)) 
            using(StreamWriter sw=new StreamWriter(fs))
            {
                Console.WriteLine("Enter Lines: ");
                string str = Console.ReadLine();
                sw.WriteLine(str);
            }

        }
        public static void CountLines()
        {
            int LineCount = 0;
            using (FileStream fs = new FileStream("StringLines.txt", FileMode.Open, FileAccess.Read)) 
            using (StreamReader sr = new StreamReader(fs))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    LineCount++;
                }


            }
            Console.WriteLine($"Total Lines Count: {LineCount}");

        }
    }
}
