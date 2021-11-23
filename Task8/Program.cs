using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ксюша\Desktop\Автоматизация BIM-проектирования";
            Console.WriteLine("Выведите на консоль содержимое папки и содержимое всех подкаталогов: ");
            if (Directory.Exists(path))
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string d in dirs)
                {
                    Console.WriteLine(d);
                    string[] subdir = Directory.GetDirectories(d);
                    foreach (string s in subdir)
                    {
                        Console.WriteLine(s);
                        string[] files = Directory.GetFiles(s);
                        foreach (string f in files)
                        {
                            Console.WriteLine(f);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
