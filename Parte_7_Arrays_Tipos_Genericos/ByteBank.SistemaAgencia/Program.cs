using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestaArrayInt();
            Console.ReadLine();
        }

        static void TestaArrayInt()
        {
            int acumulador = 0;

            // Array de inteiros com 5 posições
            int[] idades = null;
            idades = new int[3]; // inicia o array com o valor padrão nas posições [0][0][0][0][0]

            // Preenchendo o array (sempre começa no 0 - zero)
            idades[0] = 15; // [15][0][0][0][0]
            idades[1] = 28; // [15][28][0][0][0]
            idades[2] = 35; // [15][28][35][0][0]
            //idades[3] = 50; // [15][28][35][50][0]
            //idades[4] = 28; // [15][28][35][50][28]
            //idades[5] = 60;

            Console.WriteLine("Tamanho do array: " + idades.Length);

            // Acessando posição do array
            // Console.WriteLine(idades[4]);

            // Atribuindo a uma variavel - Obs: Se na posição não tem um valor, o array inicia com 0 pq o padrão do tipo inteiro é 0
            /*int idadeNoIndice4 = idades[2 + 2]; // o indice sempre é um inteiro (pode ser uma expressão que retorna um inteiro também!)
            int indice = 4;
            idadeNoIndice4 = idades[indice]; // o indice pode inclusive ser uma variável!
            Console.WriteLine(idadeNoIndice4);*/

            /*int[] outroArray = idades; // referencia do array
            Console.WriteLine(outroArray[3]);

            bool[] arrayDeBooleanos = new bool[10]; // cria com false em todas as posições pois é o valor padrão para o tipo booleano
            arrayDeBooleanos[0] = true;
            arrayDeBooleanos[1] = false;
            arrayDeBooleanos[2] = false;*/

            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                Console.WriteLine($"Acessando o array idades no indice {indice}. Valor de idades[{indice}] = {idade}");
                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine("Média: " + media);
        }
    }
}
