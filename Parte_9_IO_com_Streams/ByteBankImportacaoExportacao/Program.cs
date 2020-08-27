using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ByteBankImportacaoExportacao.Enumeradores;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            //var enderecoDoArquivo = "contas.txt";
            //var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            //// Buffer para gravar as informações temporárias
            //var buffer = new byte[1024]; // 1kb
            //var numeroDeBytesLidos = -1;

            //while (numeroDeBytesLidos != 0)
            //{
            //    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            //    EscreverBuffer(buffer);
            //}

            DesafioEnum();

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }

        static void DesafioEnum()
        {
            var btnCancelar = new Botao();
            btnCancelar.Texto = "Cancelar";
            btnCancelar.Cor = CoresBotao.Azul;

            //var linhaDeTextoDoArquivo = "Azul";
            //CoresBotao cor1 = linhaDeTextoDoArquivo; // nao compila

            //var linhaDeTextoDoArquivo = "Azul";
            //CoresBotao cor1 = (CoresBotao)linhaDeTextoDoArquivo; // nao compila

            var numero = 0;
            CoresBotao cor1 = (CoresBotao)numero; // Compila!

            Console.WriteLine(CoresBotao.Azul == (CoresBotao)128); // escreve True
            Console.WriteLine(CoresBotao.Vermelho == (CoresBotao)256); // escreve True
            Console.WriteLine(CoresBotao.Verde == (CoresBotao)512); // escreve True

            Console.WriteLine(CoresBotao.Verde == (CoresBotao)1); // escreve False e não lança exceção 
        }
    }
} 
 