using System;

namespace Nova_pasta
{
    class Program
    {
        static void invertido ( double[,] numeros)
        {
            double[,] inversao = new double [3,3];
            for(int i=0; i<3;i++)
            {
                for(int j=0; j<3; j++)
                {
                    inversao[j,i] = numeros[i,j];
                    
                }
            }
            for (int i=0; i<3;i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(" {0} ",inversao[i,j]);
                }
                Console.WriteLine();
            }
               
        }
        static void Main(string[] args)
        {
            double[,] numeros = new double [3,3];
            for (int i=0; i<3; i++)
            {
                for( int j=0; j<3; j++)
                {
                    Console.WriteLine("insira linha {0} e coluna {1}",i+1,j+1);
                    numeros[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            invertido(numeros);
        }
    }
}
