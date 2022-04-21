//Показать на экране лесенку
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledder
{   
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.Title = "LEDDER";
            Console.WriteLine("Введить будь ласка кiлькiсть сходинок");
            Console.SetCursorPosition(3, 2);
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("  ");                   
                }

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*");                    
                }

                Console.WriteLine();

                for (int l = 0; l < 1; l++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write(" *");                    
                }
                Console.WriteLine();
            }
        }
    }
}
