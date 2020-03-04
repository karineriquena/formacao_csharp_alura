using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            // Especificação do projeto
            //+----------------+--------------+-------------+------------------+
            //| Funcionário    | Salário Base | Bonificação | Aumento Salarial |
            //+----------------+--------------+-------------+------------------+
            //| Diretor        | R$ 5.000     | 50%         | 15%              |
            //| Designer       | R$ 3.000     | 17%         | 11%              |
            //| GerenteDeConta | R$ 4.000     | 25%         |  5%              |
            //| Auxiliar       | R$ 2.000     | 20%         | 10%              |
            //+----------------+--------------+-------------+------------------+
            // GerenteDeContas e Diretor, ParceiroComercial (externo - não é um funcionário!)
            //  Autenticar(senhaTentativa)
            // SistemaInterno
            //  Logar(Funcionario, senhaTentativa)
            //+-----------------------------------------------------------------

            // chamar um metodo de instancia dentro de um método static não é possivel
            // 1 tornar o metodo estatico ou instanciar o program
            // CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            // Designer não pode acessar o sistema interno
            // sistemaInterno.Logar(pedro, "adadadad");
            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
