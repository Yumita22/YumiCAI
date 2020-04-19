using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_XIV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio XIV Crear una aplicación que, cuando el usuario ingrese un número, 
            //muestre su tabla de multiplicar por pantalla. 

            int a; int b; int c; int d; int e; int f; int g; int h; int j; int k; int i;
            string l; string m; string n; string o; string p; string q; string r; string s; string t; string u; string v;
                Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());

            b = a * 1;
            c = a * 2;
            d = a * 3;
            e = a * 4;
            f = a * 5;
            g = a * 6;
            h = a * 7;
            i = a * 8;
            j = a * 9;
            k = a * 10;

            l = a.ToString();
            m = b.ToString();
            n = c.ToString();
            o = d.ToString();
            p = e.ToString();
            q = f.ToString();
            r = g.ToString();
            s = h.ToString();
            t = i.ToString();
            u = j.ToString();
            v = k.ToString();

            Console.WriteLine("{0}x1={1}",l,m);
            Console.WriteLine("{0}x2={1}", l, n);
            Console.WriteLine("{0}x3={1}", l, o);
            Console.WriteLine("{0}x4={1}", l, p);
            Console.WriteLine("{0}x5={1}", l, q);
            Console.WriteLine("{0}x6={1}", l, r);
            Console.WriteLine("{0}x7={1}", l, s);
            Console.WriteLine("{0}x8={1}", l, t);
            Console.WriteLine("{0}x9={1}", l, u);
            Console.WriteLine("{0}x10={1}", l, v);

            Console.ReadKey();
        }
    }
}
