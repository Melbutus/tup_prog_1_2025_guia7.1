using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._2_budines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budines, paq, cajas, budsobra, paqsobra;
            double kgmasa, masausada, sobrante;

            int masa;

            Console.WriteLine("escribir cantidad de masa en KG");
            masa = Convert.ToInt32(Console.ReadLine());

            kgmasa = masa * 1000;
            budines = (int)Math.Truncate(kgmasa / 55);
            sobrante = (int)(kgmasa % 55);


            paq = (int)Math.Truncate((double)budines / 12);
            cajas = (int)Math.Truncate((double)paq / 20);


            paqsobra = paq % 12;
            budsobra = budines % 12;
            masausada = (budines * 55) / 1000;

            Console.WriteLine($"cantidad de budines: {budines}, masa sobrante: {sobrante}, cantidad de paquetes: {paq},  cantidad de cajas completas: {cajas}");
            Console.ReadKey();

        }
    }
}
