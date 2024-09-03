using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] classmates = { "Clyde", "Oswell", "Reynold", "Larry", "Voltier", "Anjo" };

           
            foreach (string name in classmates)
            {
                Console.WriteLine(name);
            }

            char[,] a = new char[2, 3]
            {
                {'a','b','c'},
                {'d','e','f'}
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
                string message = "hello, ang inet";
                Console.WriteLine(message.Contains("hello"));


            
        }
    }
}
