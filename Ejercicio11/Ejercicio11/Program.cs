using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio XI 
            //Crear una aplicación que lea un carácter tecleado por el usuario e indique si se trata de una vocal, 
            //una cifra numérica o una consonante. 
            //Nota: Incluir todas las validaciones que considere necesarias(los caracteres especiales no deben tenerse en cuenta).

            string ingreso; int b;
            Console.WriteLine("Ingrese un caracter");
            ingreso = Console.ReadLine();
                        bool esnumero = int.TryParse(ingreso, out b);
            if (esnumero == true)
            { Console.WriteLine("{0} es un numero", b); }
            else
            {
                char caracter = Convert.ToChar(ingreso);
                switch (caracter)
                {
                    case 'a':
                        Console.WriteLine("{0} Es vocal", caracter);
                        break;
                    case 'e':
                        Console.WriteLine("{ 0} Es vocal", caracter);
                        break;
                    case 'i':
                        Console.WriteLine("{ 0} Es vocal", caracter);
                        break;
                    case 'o':
                        Console.WriteLine("{ 0} Es vocal", caracter);
                        break;
                    case 'u':
                        Console.WriteLine("{ 0} Es vocal", caracter);
                        break;
                    default:
                        Console.WriteLine(caracter+" Es consonante");
                        break;
                }
            }   Console.ReadKey();
        }
    }
}
