using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13DO_MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando desafio opcional - Imprimir todos os números múltiplos de 3 entre 1 e 100");

            // usando o incremento
            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }

            // outra forma de incrementar
            for (int numero = 3; numero <= 100; numero+=3)
            {
                Console.WriteLine(numero);
            }

            Console.ReadLine();
        }
    }
}
