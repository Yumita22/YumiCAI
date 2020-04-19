using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
       static void Main(string[] args)
        {
            //Crear una aplicación que, cuando el usuario ingrese dos números,
            //realice la operación aritmética (a+b)*(a-b) e indique por pantalla el resultado.

            string numero1; string numero2;
            Console.WriteLine("Ingrese un numero");
            numero1 = Console.ReadLine();
            Console.WriteLine("ingrese otro numero");
            numero2 = Console.ReadLine();

            int a = Int32.Parse(numero1);
            int b = Int32.Parse(numero2);

            int operacion;
            operacion = (a + b) * (a - b);
            Console.WriteLine(operacion);
            Console.ReadKey();
        }

    }
}
