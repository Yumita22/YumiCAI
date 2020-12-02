using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] vector1;
            Console.WriteLine("escriba un numero de 5 digitos");
            vector1 = Console.ReadLine().ToArray();

            Array.Reverse(vector1);

            string numeroalreves= new string (vector1);

            Console.WriteLine(numeroalreves);
            Console.ReadKey();

            //NOTA: Se que no esta 100% ok pero bueno
        }
    }

}

