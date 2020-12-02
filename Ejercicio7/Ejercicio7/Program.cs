using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a; string b; string c; string d; string e;
                int f; int g; int h; int i; int j;
;            
            Console.WriteLine("ingrese un numero");
            a = Console.ReadLine();
            Console.WriteLine("ingrese un numero");
            b = Console.ReadLine();
            Console.WriteLine("ingrese un numero");
            c = Console.ReadLine();
            Console.WriteLine("ingrese un numero");
            d = Console.ReadLine();
            Console.WriteLine("ingrese un numero");
            e = Console.ReadLine();

            f = Int32.Parse(a);
            g = Int32.Parse(b);
            h = Int32.Parse(c);
            i = Int32.Parse(d);
            j = Int32.Parse(e);

            int [] array1 = new int[5] { f,g,h,i,j };
                          
            Array.Sort(array1);
            Console.WriteLine("el numero menor es "+array1[0]);
            Console.WriteLine("el numero intermedio es " + array1[2]);
            Console.WriteLine("el numero menor es " + array1[4]);
            Console.ReadKey();
        }
    }
}
