using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int f = 114;
            int j = 1;

            bool esprimo = false;
            bool multiplode3 = false;
            int c = 0;

            for (i = 1; i < f; i++)
            {
                c = 0; esprimo = false; multiplode3 = false;
                if (i % 3 == 0)
                {
                    multiplode3 = true;
                }

                for (j = 1; j <= i; j++)
                {
                    if ((i % j) == 0)
                        c++;
                }
                    
                if (c == 2)
                    esprimo = true ;
                if (esprimo && (!multiplode3))
                    Console.WriteLine(i + " - es primo");
                else if ((!esprimo) && multiplode3)
                    Console.WriteLine(i + " - es multiplo de 3");
                else if (esprimo && multiplode3)
                    Console.WriteLine(i + " - es primo y múltiplo de 3");
                    
                }
            Console.ReadLine();
        }
    } 
}