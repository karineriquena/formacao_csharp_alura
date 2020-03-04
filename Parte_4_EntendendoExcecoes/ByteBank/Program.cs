using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("Catch no metodo main");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("texte.txt"))
            {
                leitor.LerProximaLinha();
            }


        }

        private static void CarregarContasSemUsing()
        {
            LeitorDeArquivo leitor = null;
            try
            {
                leitor = new LeitorDeArquivo("contasl.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            //catch (IOException e)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada");
            //}
            finally
            {
                Console.WriteLine("Executando o finally");
                if (leitor != null)
                {
                    leitor.Fechar();
                }
            }
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                // Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }

            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(514, 355425);
            //    ContaCorrente conta2 = new ContaCorrente(565, 655214);

            //    conta2.Transferir(10000, conta);

            //    // conta2.Transferir(110, conta);
            //    // conta2.Transferir(-10, conta);

            //    conta.Depositar(50);
            //    Console.WriteLine(conta.Saldo);
            //    conta.Sacar(-500);
            //    Console.WriteLine(conta.Saldo);

            //}
            //catch (ArgumentException e)
            //{
            //    if (e.ParamName == "numero")
            //    {

            //    }

            //    Console.WriteLine("Argumento com problema: " + e.ParamName);
            //    Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
            //    Console.WriteLine(e.Message);
            //}
            //catch (SaldoInsuficienteException e)
            //{
            //    Console.WriteLine(e.Saldo);
            //    Console.WriteLine(e.ValorSaque);

            //    Console.WriteLine(e.StackTrace);

            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            /*try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possível divisão por zero.");
            }
            // Exceção genérica deve ser a última na ordem, pois todas a exceções do C# derivam desta classe
            // e <- convenção de nome que aponta pra referencia da exceção
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro!");
            }
            //catch (NullReferenceException erro)
            //{
            //    Console.WriteLine(erro.Message);
            //    Console.WriteLine(erro.StackTrace);
            //    Console.WriteLine("Aconteceu um erro!");
            //}*/
        }

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
             int resultado = Dividir(10, divisor);
             Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            // ContaCorrente conta = null;
            // Console.WriteLine(conta.Saldo);
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero = " + numero + " e divisor = " + divisor);
                throw; // lançando a exceção pro método adiante
                Console.WriteLine("Código depois do throw!");
            }
        }

        // Numero = 10
        // Divisor = 20
        // resultado = 0,5

    }
}
