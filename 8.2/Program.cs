using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "‪Logs.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            StreamWriter logs = new StreamWriter(path);
            Random r = new Random();
            for (int i=0; i<10; i++)
            {
                logs.WriteLine(r.Next(0,100));
            }
            logs.Close();
            string s = "";
            int sum = 0;
            StreamReader sr = new StreamReader(path);
            //Console.WriteLine(sr.ReadToEnd());
           for (int i=0; i<10;i++)
            {
                s = sr.ReadLine();
                sum = sum + int.Parse(s);
            }
           Console.WriteLine(sum);

            Console.ReadKey();

        }
    }
}
