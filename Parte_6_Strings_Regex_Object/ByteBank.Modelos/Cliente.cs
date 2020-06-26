using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            //Cliente outroCliente = (Cliente)obj; // excessao de conversao se obj nao for Cliente
            Cliente outroCliente = obj as Cliente; // excessao de referencia nula se obj nao for Cliente

            if (outroCliente == null)
            {
                return false;
            }

            return CPF == outroCliente.CPF; // é o identificador do cliente, não precisa comparar tudo
                //Nome == outroCliente.Nome &&
                // CPF == outroCliente.CPF
                // && Profissao == outroCliente.Profissao;
        }
    }
}
