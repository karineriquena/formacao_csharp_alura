using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestaArrayInt();
            // TestaArrayComObjetos();
            // TestaListaDeContaCorrente();
            TestaListaDeObject();
            // SomarVarios(5,20,65,87);

            /*Console.WriteLine("Primeira chamada");
            DesafioSomarPares(new int[] { 1, 2, 3, 4 });

            Console.WriteLine("Segunda chamada");
            DesafioSomarPares(new int[] { 1, 2, 3, 4, 5 });

            Console.WriteLine("Terceira chamada");
            DesafioSomarPares(new int[] { 1 });*/

            Console.ReadLine();
        }

        static void TestaArrayInt()
        {
            int acumulador = 0;

            // Array de inteiros com 5 posições
            int[] idades = null;
            idades = new int[3]; // inicia o array com o valor padrão nas posições [0][0][0][0][0]

            // Preenchendo o array (sempre começa no 0 - zero)
            idades[0] = 15; // [15][0][0][0][0]
            idades[1] = 28; // [15][28][0][0][0]
            idades[2] = 35; // [15][28][35][0][0]
            //idades[3] = 50; // [15][28][35][50][0]
            //idades[4] = 28; // [15][28][35][50][28]
            //idades[5] = 60;

            Console.WriteLine("Tamanho do array: " + idades.Length);

            // Acessando posição do array
            // Console.WriteLine(idades[4]);

            // Atribuindo a uma variavel - Obs: Se na posição não tem um valor, o array inicia com 0 pq o padrão do tipo inteiro é 0
            /*int idadeNoIndice4 = idades[2 + 2]; // o indice sempre é um inteiro (pode ser uma expressão que retorna um inteiro também!)
            int indice = 4;
            idadeNoIndice4 = idades[indice]; // o indice pode inclusive ser uma variável!
            Console.WriteLine(idadeNoIndice4);*/

            /*int[] outroArray = idades; // referencia do array
            Console.WriteLine(outroArray[3]);

            bool[] arrayDeBooleanos = new bool[10]; // cria com false em todas as posições pois é o valor padrão para o tipo booleano
            arrayDeBooleanos[0] = true;
            arrayDeBooleanos[1] = false;
            arrayDeBooleanos[2] = false;*/

            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                Console.WriteLine($"Acessando o array idades no indice {indice}. Valor de idades[{indice}] = {idade}");
                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine("Média: " + media);
        }

        static void TestaArrayComObjetos()
        {
            // Quando já se sabe os itens do array, pode-se usar o açucar sintático abaixo (inicialização de arrays)
            // (para não ter que ficar se preocupando com tamanho e acesso dos indices na ordem correta)
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
                }; // valor padrão para um tipo de referência é null

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(10);

            // nomear o argumento para alterar somente o segundo argumento opcional
            lista.MeuMetodo(numero: 10);

            ContaCorrente contaDoGui = new ContaCorrente(11111, 11111111);

            /*lista.Adicionar(contaDoGui);
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 4456668));
            lista.Adicionar(new ContaCorrente(874, 7781438));
            lista.Adicionar(new ContaCorrente(874, 7781438));
            lista.Adicionar(new ContaCorrente(874, 7781438));
            lista.Adicionar(new ContaCorrente(874, 7781438));
            lista.Adicionar(new ContaCorrente(874, 7781438));
            lista.Adicionar(new ContaCorrente(874, 7781438));
            lista.Adicionar(new ContaCorrente(874, 7781438));
            lista.Adicionar(new ContaCorrente(874, 7781438));
            lista.Adicionar(new ContaCorrente(874, 7781438));*/

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui, 
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668)
            };

            // palavra reservada 'params' na assinatura do metodo permite tanto um array como passar item a item 
            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(
                contaDoGui, 
                new ContaCorrente(874, 7781438), 
                new ContaCorrente(874, 4456668)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            /*lista.EscreverListaNaTela();
            lista.Remover(contaDoGui);
            Console.WriteLine("Após remover o item");
            lista.EscreverListaNaTela();*/
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            Console.WriteLine($"Soma Total: {acumulador}");
            return acumulador;
        }

        // Soma os numeros de um array. Exemplo no array {1,2,3,4} a saida é 1+2 = 3, 3+4 = 7
        // Se fosse o array {1,2,3,4,5} como o tamanho é impar a saida deve ser a mesma acima e o ultimo numero deve ser ignorado
        static void DesafioSomarPares(int[] numeros)
        {
            for (int i = 0; i < numeros.Length -1; i+=2 )
            {
                int primeiroNumero = numeros[i];
                int segundoNumero = numeros[i+1];

                int soma = primeiroNumero + segundoNumero;

                Console.WriteLine($"{primeiroNumero}+{segundoNumero} = {soma}");
            }
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice {i}: {idade}");
            }
        }
    }
}
