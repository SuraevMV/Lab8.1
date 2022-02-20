using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Папка/Файл.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                int numbWord = 0;
                int numbSymbol = 0;
                int numbLine = 0;
                foreach (string line in File.ReadLines(path))
                {
                    numbLine++;
                    string[] line1 = line.Split();
                    foreach (string a in line1)
                    {
                        numbWord++;
                        numbSymbol += a.Length;
                    }
                }

                Console.WriteLine("Число строк: {0}\nЧисло слов: {1}\nЧисло символов: {2}", numbLine, numbWord, numbSymbol);
                Console.ReadKey();
            }
        }
    }
}
