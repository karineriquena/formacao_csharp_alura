using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {    
        // É uma propriedade estática da classe (não do objeto) - ela fica "compartilhada entre as instâncias"
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        // propriedades obrigatórias devem ficar no construtor
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        // metodos abstratos só podem fazer parte de classes abstratas
        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
