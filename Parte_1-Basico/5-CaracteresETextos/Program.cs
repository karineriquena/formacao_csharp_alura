using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e textos");

            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            // arroba quebra linha
            string cursosProgramacao = 
@" - .NET
 - Java
 - JavaScript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("A execução acabou. Tecle enter para sair. . . ");
            Console.ReadLine();
        }
    }
}
