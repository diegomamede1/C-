using System;

namespace Exercicio_n3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, i, cont;
            i = 1;
            cont = 0;
            Console.WriteLine("informe o numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (i <= numero)
            {

                if (numero % i == 0)
                {

                    cont++;
                }
                    i++;
            }

            if (cont == 2)
            {

                Console.WriteLine("o numero é primo");

            }

            else
            {

                Console.WriteLine("o numero não é primo");

            }

        }
    }
}
