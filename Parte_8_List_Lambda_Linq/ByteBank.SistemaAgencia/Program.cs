using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListComExtensionMethod();
            // UsoDoVar();
            // ListComSort();

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 18950),
            };

            contas.Sort();

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();
        }

        static void ListComExtensionMethod()
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            // No ADDRANGE não é possivel usar igual o argumento params
            idades.AddRange(new int[] { 1, 2, 3, 9 });

            idades.Remove(5);


            // ListExtensoes.AdicionarVarios(idades, 1, 5687, 1987, 1567, 987);
            // metodo de extensão após colocar o this no parametro
            idades.AdicionarVarios(1, 5687, 1987, 1567, 987);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }

        static void UsoDoVar()
        {
            // var é usado para o compilador inferir o tipo da variavel que tem a direita na atribuição (tipo implicito de acordo com a atribuição)
            // nome: inferencia de tipo de variavel
            var conta = new ContaCorrente(344, 565656);
            var gerenciador = new GerenciadorBonificacao();
            var gerenciadores = new List<GerenciadorBonificacao>();
            var idade = 18;
            var soma = SomarVarios(18, 23, 25, 51, 55);

            conta.Depositar(3443);
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            Console.WriteLine($"Soma Total: {acumulador}");
            return acumulador;
        }

        static void ListComSort()
        {
            var nomes = new List<string>()
            {
                "Wellington",
                "Guilherme",
                "Luana",
                "Ana"
            };
            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();
            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);
            idades.AdicionarVarios(18, 45, 53, 12, 98);
            idades.AdicionarVarios(99, -1);

            idades.Sort();


            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }

    }
}
