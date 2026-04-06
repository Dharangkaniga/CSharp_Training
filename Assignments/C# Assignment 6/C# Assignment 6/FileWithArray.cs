using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_6
{
    internal class FileWithArray
    {
        public static void Main()
        {
            WriteStream();
            ReadStream();
        }
        public static void WriteStream()
        {
            using(FileStream fs=new FileStream("ArrayString.txt",FileMode.Create,FileAccess.Write))
            using(StreamWriter sw=new StreamWriter(fs))
            {
                Console.WriteLine("Enter Size Of Array: ");
                int size = Convert.ToInt32(Console.ReadLine());
               
                string[] Strarray=new string[size];
                Console.WriteLine("Enter Elements Of Array: ");
                for (int i = 0; i < size; i++)
                {
                    Strarray[i]=Console.ReadLine();
                    sw.WriteLine(Strarray[i]);
                }
            }


        }
        public static void ReadStream()
        {
            using (FileStream fs = new FileStream("ArrayString.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string line;
                Console.WriteLine("Array Elements: ");
                while((line=sr.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
               
            }

        }

    }
}
