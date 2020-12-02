using System;

namespace Ejercicio18
{
    class Program
    {


        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Escribir el numero");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Decimal a Binario{0} -> {1}", n, abinario(n));
            Console.WriteLine("Decimal a OCtal{0} -> {1}", n, aoctal(n));
            Console.WriteLine("Decimal a Hexadecimal{0} -> {1}", n, ahexa(n));
            Console.ReadKey();
        }

        #region hexa
        private static String ahexa(int n)
        {
            return Convert.ToString(n, 16).ToUpper();
        }
        #endregion

        #region octal
        private static String aoctal(int n)
        {
            return Convert.ToString(n, 8);
        }
        #endregion
        #region binario
        private static String abinario(int n)
        {
            return Convert.ToString(n, 2);
        }
        #endregion

    }
}