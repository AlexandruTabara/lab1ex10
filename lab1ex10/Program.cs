using System;

namespace lab1ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 10
                Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.
                   Numarul are exact 2 cifre */

            int n, suma = 0, m;
            Console.Write("Introdu un numar: ");

            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                suma = suma + m;
                n = n / 10;
            }
            Console.Write("Suma este " + suma);
        }
    }
}
