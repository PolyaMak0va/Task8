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
        // Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ксюша\Desktop\3ds Max";
            Console.WriteLine("Выведите на консоль содержимое папки и содержимое всех подкаталогов: ");
            if (Directory.Exists(path))
            {
                try
                {
                    string[] dirs = Directory.GetDirectories(path, "**", SearchOption.AllDirectories);
                    Console.WriteLine(dirs.Length);
                    foreach (string d in dirs)
                    {
                        Console.WriteLine(d);
                        string[] files = Directory.GetFiles(d);
                        foreach (string f in files)
                        {
                            Console.WriteLine(f);
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.ToString());
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
