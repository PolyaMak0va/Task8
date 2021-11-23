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

            Random random = new Random();
            string path = @"C:\Users\Ксюша\Desktop\Автоматизация BIM-проектирования\ЗАДАНИЕ 8. РАБОТА С ФАЙЛОВОЙ СИСТЕМОЙ/Logs.txt";
            int S = 0;
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                int[] array = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    sw.Write("{0} ", array[i]);
                    S += array[i];
                }
                Console.WriteLine("{0}", S);
            }
            Console.ReadKey();
        }
    }
}
