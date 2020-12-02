using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio17

//Ejercicio XVII 
//Crear una aplicación que tome los nombres y sueldos de cinco empleados, 
//para mostrar por pantalla el sueldo mayor y el nombre del empleado. 
{
    class Ejercicio17
    {
        private string[] nombres;
        private float[] sueldos;

        public void Cargar()
        {
            nombres = new string[5];
            sueldos = new float[5];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Escribir el nombre del empleado:");
                nombres[i] = Console.ReadLine();
                Console.Write("Escribir el sueldo:");
                string input;
                input = Console.ReadLine();
                sueldos[i] = float.Parse(input);
            }
        }

        public void Ordenarsueldo()
        {
            float mayor;
            int posicion;
            mayor = sueldos[0];
            posicion = 0;

            for (int i = 1; i < nombres.Length; i++)
                if (sueldos[i] > mayor)
                {
                    mayor = sueldos[i];
                    posicion = i;
                }

            Console.WriteLine("El empleado con mayor sueldo es " + nombres[posicion]);
            Console.WriteLine("Su sueldo es " + mayor);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Ejercicio17 pv = new Ejercicio17();
            pv.Cargar();
            pv.Ordenarsueldo();
        }
    }
}

