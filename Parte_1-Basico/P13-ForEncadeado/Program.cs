using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13 - For encadeado");

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********

            // escrevendo asteriscos com o break
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;

                }
                Console.WriteLine(); // pula linha
            }

            // Uma forma diferente de fazer o desenho de asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write("*");

                Console.WriteLine(); // pula linha
            }

            Console.WriteLine("A execução acabou. Tecle enter para finalizar. . . ");
            Console.ReadLine();
        }
    }
}
