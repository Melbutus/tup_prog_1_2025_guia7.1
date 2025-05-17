using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._3_patentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region dividir el nº
            int numero = 1001;
            int baja = numero % 1000;     // Parte numérica 
            int alta = numero / 1000;     // Parte letras     
            #endregion

            alta = alta % (26 * 26 * 26); 

            #region extraemos las letras
            char d6 = (char)((alta % 26) + 65);  
            alta = alta / 26;                   

            char d5 = (char)((alta % 26) + 65);  
            alta = alta / 26;                   

            char d4 = (char)((alta % 26) + 65);
            #endregion

            string numeros = baja.ToString("D3");  // 1 → "001"
            string patente = "" + d6 + d5 + d4 + numeros;

            Console.WriteLine(patente);  // Resultado: "BAA001"


        }
    }
}
