using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\dz2\\";
            

            if (Directory.Exists(path))
            {
                Console.WriteLine("Каталоги:");
                string[] dirs = Directory.GetDirectories(path);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                


            }
            Console.ReadKey();
        }
    }
}
