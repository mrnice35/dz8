using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "Logs";
            int S = 0;
            
             DirectoryInfo directory = new DirectoryInfo(path1);

            if (!directory.Exists)
            {
                directory.Create();
            }
            string path = "Logs/Logs.text";
            StreamWriter sw = new StreamWriter(path, false);
            {
                int[] array = new int[10];

                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 100);

                }
                string number = string.Join(" ", array);
                sw.WriteLine(number);
                sw.Close();
            }

            StreamReader sr = new StreamReader(path);
            

                string s = sr.ReadToEnd();
                string[] sum = s.Split(new char[] { ' ' });
            for (int i = 0; i < 10; i++)
            {
                int stringToInt = Convert.ToInt32(sum[i]);
                S += stringToInt;
               

            }

             Console.WriteLine(S);      
            Console.ReadKey();


                          
             
                 
           
        }
    }
}

                
            
                     

                     
            


        
       