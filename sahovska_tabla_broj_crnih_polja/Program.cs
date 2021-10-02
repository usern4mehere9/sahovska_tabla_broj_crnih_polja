using System;

namespace sahovska_tabla_broj_crnih_polja
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, cp;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            cp = (m * n) / 2;

            Console.WriteLine(cp);
        }
    }
}
