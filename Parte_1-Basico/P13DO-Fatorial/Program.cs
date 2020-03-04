using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13DO_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando desafio opcional - Imprimir todos os resultados de fatorial de 1 a 10");

            int fatorial = 1;

            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
