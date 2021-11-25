using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8._1
{
    class Program
    {
        //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
        //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ксюша\Desktop\Автоматизация BIM-проектирования\ЗАДАНИЕ 8. РАБОТА С ФАЙЛОВОЙ СИСТЕМОЙ/Logs.txt";

            Random random = new Random();         
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                int[] array = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    sw.Write("{0} ", array[i]);
                }
            }
            //using (FileStream fs = File.OpenRead(path))
            //{
            //    byte[] b = new byte[1024];
            //    UTF8Encoding temp = new UTF8Encoding(true);

            //    while (fs.Read(b, 0, b.Length) > 0)
            //    {
            //        Console.WriteLine(temp.GetString(b));
            //    }
            //}
            using (StreamReader sr = new StreamReader(path))
            {
                string console = sr.ReadLine();

            }
                //int S = 0;
                //S += array[i];
                //Console.Write("{0}", S);
                //
                //{
                //    
                //    
                //    //int[] sumArray=new
                //    //
                //    //

                //}



                Console.ReadKey();
        }
    }
}
