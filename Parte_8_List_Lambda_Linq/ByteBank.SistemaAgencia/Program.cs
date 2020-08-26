using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
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
            // ListComIComparebleAndIComparer();
            // ListComOrderBy();
            ListComWhere();
            

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

        static void ListComIComparebleAndIComparer()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 1),
                new ContaCorrente(340, 99999),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 18950),
            };

            // contas.Sort(); ~~> Chama a implementação dada em IComparable implementado pela classe ContaCorrente

            contas.Sort(new ComparadorContaCorrentePorAgencia()); // ~~> Chama a implementação dada em IComparer, uma classe que implementa uma comparação para outro objeto qualquer

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }
        }
        static void ListComOrderBy()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 999),
                null,
                new ContaCorrente(340, 4),
                new ContaCorrente(340, 456),
                new ContaCorrente(340, 10),
                null,
                null,
                new ContaCorrente(290, 123),
            };

            IOrderedEnumerable<ContaCorrente> contasOrdenadas = 
                contas.OrderBy(conta => { // ~~> Expressão Lambda
                    if (conta == null)
                    {
                        // retornar o maior numero inteiro possivel pois queremos que fique no final a referencia nula
                        return int.MaxValue;
                    }
                    return conta.Numero;  
                }); 

            foreach (var conta in contasOrdenadas)
            {
                if (conta != null)
                {
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                } 
            }
        }

        static void ListComWhere()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 999),
                null,
                new ContaCorrente(340, 4),
                new ContaCorrente(340, 456),
                new ContaCorrente(340, 10),
                null,
                null,
                new ContaCorrente(290, 123),
            };

            /*var listaSemNulos = new List<ContaCorrente>();
            foreach (var conta in contas)
            {
                if (conta != null)
                {
                    listaSemNulos.Add(conta);
                }
            }

            IEnumerable<ContaCorrente> contasNaoNulas = 
                contas.Where(conta => conta != null);
            
            IOrderedEnumerable<ContaCorrente> contasOrdenadas =
                listaSemNulos.OrderBy<ContaCorrente, int>(conta => conta.Numero);
            */

            var contasOrdenadas = contas
                .Where(conta => conta != null) // ~~> Linq é o nome da tecnologia para usar as ordenações, where, com metodos de extensao e etc
                .OrderBy(conta => conta.Numero);


            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }
        }
    }
}
