using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        public static int i;

        static void Main(string[] args)
        {
            int a = 114;
            for (int i = 1; i < a; i++) 
            { 
                Console.Write(i);
                {
                    if (i % 3 == 0)
                        Console.Write(" - Foo");
                    if (i % 5 == 0)
                        Console.Write(" - Bar");
                }
                Console.WriteLine(" ");
                Console.Read();
            }
        }
    }   

}
