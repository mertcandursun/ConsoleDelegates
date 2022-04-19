using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    class Program
    {
        /* delegateler bir nevi metod pointerlarıdır
         * yani metodları yönetirler
         * Delegate tipinden bir nesne türetip rahatlıkla işlemler yapabilememizi sağlarlar.
         *
         *
         * aşağıda ki örnekte çevre ve alan hesabı yapan
         * metodlarımı ana metodum içerisinde delegateden
         * nesne türetip parametre geçirerek kullandım.
         *
         * ayrıca delegatein parametre içinde ki değişkenlerinde aşağıdakilerle aynı olma zorunlulu yoktur.
         */

        
        delegate double Dikdortgen(double x, double y);
        
        static void Main(string[] args)
        {
            Dikdortgen test = new Dikdortgen(alan);
            Console.WriteLine(test(3,8));
            Console.ReadLine();
        }

        static double alan(double a, double b)
        {
            return a * b;
        }

        static double cevre(double a, double b)
        {
            return 2 * (a + b);
        }
    }
}
