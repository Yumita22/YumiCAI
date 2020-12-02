using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio VIII
            //Crear una aplicación que, cuando el usuario ingrese una fecha, calcule la diferencia entre ésta y el día de hoy, 
            //mostrando por pantalla "La diferencia de fechas es de *nnnnn* días."

            string a; DateTime b; TimeSpan c; 
            Console.WriteLine("ingrese una fecha");
            a = Console.ReadLine();
            b = Convert.ToDateTime(a);
            c = (DateTime.Today - b);
            string d = Convert.ToString(c);
            Console.WriteLine("dias que pasaron: ");  Console.WriteLine(d);
            Console.ReadKey();

            //no sé como hacer para que no muestre las horas y los segundos (tampoco para q quede bien)
        }
    }
}
