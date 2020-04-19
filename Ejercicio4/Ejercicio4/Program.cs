using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Program
    {
        public static bool Main ()

        {

            string str1; string str2;
            Console.WriteLine("esccriba la primer palabra");
            str1 = Console.ReadLine();
            Console.WriteLine("escriba lasegunda palabra");
            str2 = Console.ReadLine();

            int contar1 = 0;
            int contar2 = 0;
            bool anagrama = false;

        for (int i = 0; i< str1.Length-1; i++)
            {
                contar1++;
                contar2 = str2.Length - 1;

                if (str2.Contains(str1(i) && contar1 = contar2))
                {
                    anagrama = true;
                }
            }
            return anagrama;



        }
        

    }
}
