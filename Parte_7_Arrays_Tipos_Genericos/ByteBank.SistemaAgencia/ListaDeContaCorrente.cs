using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public int Tamanho { 
            get { 
                return _proximaPosicao; 
            } 
        }

        public ListaDeContaCorrente(int capacidadeInicial = 5) // argumento opcional
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texto padrao", int numero = 5)
        {

        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            // Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params ContaCorrente[] itens)
        {
            foreach (ContaCorrente conta in itens)
            {
                Adicionar(conta);
            }
        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente itemAtual = _itens[i];

                // equivalencia e não igualdade (o Equals está sobrescrito na classe ContaCorrente pq uma conta corrente é equivalente quando tem o mesmo Numero e Agencia)
                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < (_proximaPosicao - 1); i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void EscreverListaNaTela()
        {
            for (int i = 0; i <_proximaPosicao; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"Conta no indice {i}: numero {conta.Agencia} {conta.Numero}");
            }
        }

        public ContaCorrente GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            // dobro o tamanho da lista para não ficar aumentando a lista cada vez que adicionar mais um item
            int novoTamanho = _itens.Length * 2; 

            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            // Console.WriteLine("Aumentando capacidade da lista!");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            // Copiando os itens do array _itens para o _novoArray
            /*for(int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                Console.WriteLine(".");
            }*/

            // Outra forma de copiar os itens seria usando essa função do .NET
            Array.Copy(sourceArray: _itens, destinationArray: novoArray, length: _itens.Length);

            // Outra sobrecarga do Copy, onde se copia a partir do array _itens, no indice 4, para o novoArray a partir do indice 2 copiando apenas 3 itens;
            /*Array.Copy(
                sourceArray: _itens,
                sourceIndex: 4,

                destinationArray: novoArray,
                destinationIndex: 2,

                length: 3);*/

            _itens = novoArray;
        }

        // Sintaxe para criar um indexador
        public ContaCorrente this[int indice] {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}
