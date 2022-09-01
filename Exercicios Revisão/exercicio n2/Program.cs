using System;

namespace exercicio_n2
{
    class Program
    {

        static String ParOuImpar(double n1)
        {

            if(n1 % 2 == 0 )
            {

                return "par";

            }

            else
            {

                return "impar";

            }

        }


        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("informe o numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} é {1}", numero, ParOuImpar(numero));

        }
    }
}
