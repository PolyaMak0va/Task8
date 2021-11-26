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
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine("Содержание текстового документа.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Нажмите любую кнопку для выхода.");

            int S = 0;
            int N = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
                N = int.Parse(sr.ReadToEnd());
                //int[] arraySum = new int[lines.Length];
                //while ((lines = sr.ReadLine()) != null)
                //    foreach (int l in arraySum)
                //{
                //    S += int.TryParse(l);
                //    S += l;
                //}          
            }
            S += N;
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
