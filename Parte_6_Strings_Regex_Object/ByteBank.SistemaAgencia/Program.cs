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

            // Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = "";
            string textoQualquer = "sdfisfishdfkfsk";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));

            // Testando o IndexOf com palavra
            // moedaOrigem=real&moedaDestino=dolar
            //                              |
            //              ----------------'
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);
            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));

            // ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            Console.ReadLine();
        }
    }
}
