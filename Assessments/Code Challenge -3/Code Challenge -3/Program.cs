using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge__3
{

internal class Program
    {
        static void Main(string[] args)
        {
            string file = "existingfile.txt";

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine("This is an appended text");
            }

            using (FileStream fs = new FileStream("existingfile.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter sw1 = new StreamWriter(fs))
            {
                sw1.WriteLine("There is no Existing File");
                sw1.WriteLine("This is a new created file");
                sw1.WriteLine(" --- CODE CHALLENGE 3 ---");
            }
            using (FileStream fs = new FileStream("existingfile.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}

