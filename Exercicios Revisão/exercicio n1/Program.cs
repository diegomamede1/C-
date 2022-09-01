using System;

namespace exercicios
{
    class Program
    {

        static void SubRotina(int n1)
        {
            
            if(n1 % 2 == 0)

            Console.WriteLine("o numero é par");

            else
            {

                Console.WriteLine("o numero é impar");

            }

        }

        static void Main(string[] args)
        {
            int numero;
            
            Console.WriteLine("informe o numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            SubRotina(numero);


        }
    }
}
