using System;

namespace Exercicio_n1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 1;

            while(numero <= 100)
            {

                if(numero % 2 == 0)
                {

                    Console.WriteLine("{0}", numero);
                    
                }
                    numero++;

            }
        }
    }
}
