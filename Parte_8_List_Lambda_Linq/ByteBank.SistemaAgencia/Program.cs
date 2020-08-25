using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38); 
            idades.Add(61);

            // No ADDRANGE não é possivel usar igual o argumento params
            idades.AddRange(new int[] { 1, 2, 3, 9 });

            idades.Remove(5);


            // ListExtensoes.AdicionarVarios(idades, 1, 5687, 1987, 1567, 987);
            // metodo de extensão após colocar o this no parametro
            idades.AdicionarVarios(1, 5687, 1987, 1567, 987);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }

    }
}
