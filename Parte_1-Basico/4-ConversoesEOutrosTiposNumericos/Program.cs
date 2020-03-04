using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversões e outros tipos numéricos");

            double salario = 1200.50;

            // O int é um tipo de variável de 32 bits
            int salarioEmInteiro = (int)salario; // <--- casting
            Console.WriteLine(salarioEmInteiro);

            // O long é um tipo de variável de 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variável de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            // f é um sufixo pra falar pro C# que não é double que quero usar, é float mesmo (não é comum usar float);
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("A execução acabou. Tecle enter para sair. . . ");
            Console.ReadLine();
        }
    }
}
