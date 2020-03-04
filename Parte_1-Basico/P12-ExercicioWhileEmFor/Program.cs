using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_ExercicioWhileEmFor
{
    class Program
    {
        static void Main(String[] args)
        {
            int contador = 1;
            //while (contador <= 10)
            //{
            //    Console.WriteLine(contador);
            //    contador++;
            //}

            for (contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }

            Console.ReadLine();
        }
    }
}
