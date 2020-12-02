using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_XVI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio XVI Crear una aplicación que, cuando el usuario ingrese un número, 
            //lo muestre por pantalla e indique cuántos dígitos tiene. 

            int a; int caracteres; string b;
                Console.WriteLine("Ingrese un número");
            a = int.Parse(Console.ReadLine());
            b = a.ToString();
            caracteres = b.Length;
            Console.WriteLine("El numero es {0} y tiene {1} caracteres", b, caracteres);
            Console.ReadKey();
        }
    }
}
