using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando extração de números com expressão regular (Regex)
            // Suponha o texto abaixo:

            // Olá, meu nome é Guilherme e você pode entrar em contato comigo
            // pelo número 8457-4456!

            // Ou esse texto:

            // Meu nome é Guilherme, me ligue em 4784-4546

            // Expressão regular - 'Linguagem do padrão - tem que estar dentro das regras'
            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4}[-][0-9]{4}"; 
            // string padrao = "[0-9]{4,5}[-][0-9]{4}"; // supondo que o numero tem o '9' na frente
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}"; // supondo que o numero não tem o hifen
            // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}"; // simplificando o de cima pois o grupo só tem 1 caractere no grupo "-"
            // string padrao = "[0-9]{4,5}-?[0-9]{4}"; // a '?' substitui o quantificador {0,1} "opcional"

            string padrao = "[0-9]{4,5}-?[0-9]{4}";            
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 94784-4546"; 

            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value); // retorna o valor do texto que dá match com a regex
            
            // Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao)); // IsMatch retorna um booleano


            
            
            
            
            
            
            /*string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
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
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));*/

            // Testando o IndexOf com palavra
            // moedaOrigem=real&moedaDestino=dolar
            //                              |
            //              ----------------'
            // <nome>=<valor>
            /*string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);
            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));*/

            // Testando remoção de partes da string
            //string testeRemocao = "primeiraParte&parteParaRemover";
            //int indiceEComercial = testeRemocao.IndexOf("&");
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            //Console.ReadLine();

            // Testando quando o IndexOf não encontra o caractere na string
            //string qualquer = "sdfsdfjkgljdgf";
            //Console.WriteLine(qualquer.IndexOf("1"));
            //Console.ReadLine();

            // Testando diferenciação de maiuscula e minúscula com replace e upper e lower
            //string mensagemOrigem = "PALAVRA";
            //string termoBusca = "ra";

            //Console.WriteLine(termoBusca.ToUpper());
            //Console.WriteLine(mensagemOrigem.ToLower());

            //termoBusca = termoBusca.Replace("r", "R");
            //Console.WriteLine(termoBusca);

            //termoBusca = termoBusca.Replace("a", "A");
            //Console.WriteLine(termoBusca);

            //Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            //Console.ReadLine();

            // Testando Startswith, Endswith e Contains
            /*string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");
            Console.WriteLine("(IndexOf) É uma URL do ByteBank? " + (indiceByteBank == 0));
            Console.WriteLine("(StartsWith) É uma URL do ByteBank? " + (urlTeste.StartsWith("https://www.bytebank.com")));
            Console.WriteLine("(EndsWith) Está na página do cambio? " + (urlTeste.EndsWith("cambio/")));
            Console.WriteLine("(Contains) Contém uma string? " + (urlTeste.Contains("ByteBank")));
            Console.ReadLine();*/

            // Testando classe de parametros
            /*string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);
            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            string valorMoedaDestino = extratorDeValores.GetValor("moedaDestino");
            string valorConverter = extratorDeValores.GetValor("VALOR");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);
            Console.WriteLine("Valor de moedaDestino: " + valorMoedaDestino);
            Console.WriteLine("Valor para converter (valor): " + valorConverter);*/

            Console.ReadLine();
        }
    }
}
