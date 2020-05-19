using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
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
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            int indiceInterrogacao = url.IndexOf("?");
            string argumentos = url.Substring(indiceInterrogacao + 1); // inclusivo: a partir do indice 6, contendo o indice 6

            Console.WriteLine(indiceInterrogacao);
            Console.WriteLine(url);
            Console.WriteLine(argumentos);

            string textoVazio = "";
            string textoNulo = "";
            string textoQualquer = "sdfisfishdfkfsk";

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));

            // ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            Console.ReadLine();
        }
    }
}
