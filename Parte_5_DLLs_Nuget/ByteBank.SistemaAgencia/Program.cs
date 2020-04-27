using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2020, 5, 2);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40);// dataFimPagamento - dataCorrente;
            string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(mensagem);
            //ContaCorrente conta = new ContaCorrente(847, 489754);
            //new ContaCorrente(123, 456456);

            //FuncionarioAutenticavel carlos = null;
            //carlos.Autenticar("kashdajdha");

            //Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
