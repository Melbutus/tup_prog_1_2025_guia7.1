using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double montoreparto, m1, m2, m3, m4, p1, p2, p3, p4;
            int edad1, edad2, edad3, edad4,suma;
            

            Console.WriteLine("Ingrese monto a repartir");
            montoreparto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la edad de la primer niña");
            edad1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la segunda niña");
            edad2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la tercer niña");
            edad3= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la cuarta niña");
            edad4= Convert.ToInt32(Console.ReadLine());

            suma = edad1 + edad2 + edad3 + edad4;
            p1 = (edad1 * 100)/ suma;
            p2 = (edad2 * 100) / suma;
            p3 = (edad3 * 100) / suma;
            p4 = (edad4 * 100) / suma;

            m1 = (montoreparto * p1) / 100;
            m2 = (montoreparto * p2) / 100;
            m3 = (montoreparto * p3) / 100;
            m4 = (montoreparto * p4) / 100;

            Console.WriteLine($"La edad de la primer niña es {edad1}, porcentaje asignado {p1} y monto asignado {m1}");
            Console.WriteLine($"La edad de la primer niña es {edad2}, porcentaje asignado {p2} y monto asignado {m2}");
            Console.WriteLine($"La edad de la primer niña es {edad3}, porcentaje asignado {p3} y monto asignado {m3}");
            Console.WriteLine($"La edad de la primer niña es {edad4}, porcentaje asignado {p4} y monto asignado {m4}");
            Console.ReadKey();
        }
    }
}
