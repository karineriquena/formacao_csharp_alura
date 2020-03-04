using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class OldProgram
    {
        static void Old() 
            // main(string[] args)
        {

            // Especificação do projeto
            //+----------------+--------------+-------------+------------------+
            //| Funcionário    | Salário Base | Bonificação | Aumento Salarial |
            //+----------------+--------------+-------------+------------------+
            //| Diretor        | R$ 5.000     | 50%         | 15%              |
            //| Designer       | R$ 3.000     | 17%         | 11%              |
            //| GerenteDeConta | R$ 4.000     | 25%         |  5%              |
            //| Auxiliar       | R$ 2.000     | 20%         | 10%              |
            //+----------------+--------------+-------------+------------------+


            /*GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do Carlos: " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            // codigo válido por conta herança!
            // Funcionario pedro = new Diretor(); 

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            // polimorfismo
            Funcionario robertaTeste = roberta;

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionário: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();*/

        }
    }
}
