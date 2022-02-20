using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
            string path = "Logs/Log.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (int a in numbers)
                {
                    numbers[a] = random.Next(0, 10);
                    Console.Write(numbers[a]);
                    sw.Write(numbers[a]);
                }
            }
        }
    }
}
