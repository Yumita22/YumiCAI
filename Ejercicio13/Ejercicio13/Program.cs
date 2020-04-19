using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio XIII Crear una aplicación que, cuando el usuario ingrese un número, 
            //calcule el factorial del mismo y lo muestre por pantalla. 

            int a; int factorial = 1;
            Console.WriteLine("ingrese un numero");
            a= int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++) 
                {
                factorial = factorial * i;
                };
            Console.WriteLine("El factorial de {0} es {1}", a, factorial);
            Console.ReadKey();
        }
    }
}
