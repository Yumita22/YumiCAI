using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio IX
            //Crear una aplicación que pida al usuario su nombre e indique por pantalla “¡Hola, *usuario * !” 
            //si ingresa su nombre, en caso contrario dirá “No te conozco”.
            //Por ejemplo, si el usuario es Suyai, e ingresa el nombre “Suyai” dirá “¡Hola, Suyai!”, si no, “No te conozco”

            string a;
            Console.WriteLine("Escriba su nombre");
            a = Console.ReadLine();

            if (string.IsNullOrEmpty(a))
            {
                Console.WriteLine("no te conozco");
            }
            else
            {
                Console.WriteLine("hola,{0} ", a);
            }
            Console.ReadKey();
        }
    }
}
