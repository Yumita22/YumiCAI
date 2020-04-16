using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIII
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            Console.WriteLine("Escribi una palabra");
            string s = Console.ReadLine();
            int i = s.Length;
            for (int j = i - 1; j >= 0; j--)
            {
                str = str + s[j];
            }
            if (str == s)
            {
                Console.WriteLine(s + " es un palindromo");
            }
            else
            {
                Console.WriteLine(s + " no es palindromo");
            }
            Console.Read();
        }
    }
}
    

