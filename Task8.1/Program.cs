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
            string path = @"C:\Users\Ксюша\Desktop\Автоматизация BIM-проектирования\ЗАДАНИЕ 8. РАБОТА С ФАЙЛОВОЙ СИСТЕМОЙ\Logs.txt";
        
            Random random = new Random();
            if (!File.Exists(path))
            {
                var newFile = File.Create(path);
                newFile.Close();
            }
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                int[] array = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    sw.Write("{0} \n", array[i]);
                }
            }
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine("Содержание текстового документа.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Нажмите любую кнопку для выхода.");

            int sum = 0;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sum += int.Parse(line);
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
