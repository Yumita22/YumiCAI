using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioXV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio XV Crear una aplicación que verifique, en tres oportunidades, si la clave ingresada por el usuario 
            //es correcta. La clave será el nombre del usuario, si acierta mostrará por pantalla “Bienvenido, *usuario*”, 
            //si no acierta mostrará “Acceso denegado. La contraseña no es correcta”, y cuando se cumplan los tres intentos
            //mostrará “Clave bloqueada”.

            string a; string b; int intentos = 0;
            Console.WriteLine("Ingrese su usuario");
            b = Console.ReadLine();
            for (intentos = 0; intentos < 3; intentos++)
            {
                Console.WriteLine("Ingrese su contraseña");
                a = Console.ReadLine();
                if (a == b)
                {
                    Console.WriteLine("Bienvenido, {0}", b);
                    goto fin;
                }
                else
                    Console.WriteLine("Acceso denegado. La contraseña no es correcta");
            }
            Console.WriteLine("Usuario Bloqueado");
        fin:
            Console.ReadKey();
        }
    }
}
