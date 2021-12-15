using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/79138/Documents/Архив";
            Console.WriteLine("СПИСОК КАТАЛОГОВ ПАПКИ АРХИВ");
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (DirectoryInfo d in dir.GetDirectories())

            {
                Console.WriteLine(d.Name);
                Console.WriteLine("СПИСОК ФАЙЛОВ");
                foreach (FileInfo f in d.GetFiles())
                {
                    Console.WriteLine(f.Name);
                }
                

            }
            Console.ReadKey();
        }
    }
}
