using System;

namespace Exercicios_Matriz_FP_08
{
  class Program
  {
    static void Soma(int[,] matriz1, int[,] matriz2, int[,] soma)
    {

      int i, j;
      for (i = 0; i < 3; i++)
      {

        for (j = 0; j < 3; j++)
        {

          soma[i, j] = matriz1[i, j] + matriz2[i, j];
          Console.WriteLine("Soma das matrizes: {0}", soma[i, j]);

        }

      }

    }
    static void LeMatriz(int[,] matriz1, int[,] matriz2)
    {
      int i, j;
      for (i = 0; i < 3; i++)
      {

        for (j = 0; j < 3; j++)
        {
          Console.WriteLine("informe o valor da MATRIZ1 linha {0} e coluna {1}:", i, j);
          matriz1[i, j] = Convert.ToInt32(Console.ReadLine());

        }

      }

      for (i = 0; i < 3; i++)
      {

        for (j = 0; j < 3; j++)
        {

          Console.WriteLine("informe o valor da MATRIZ2 linha {0} e coluna {1}:", i, j);
          matriz2[i, j] = Convert.ToInt32(Console.ReadLine());

        }

      }


    }
    static void Main(string[] args)
    {

      int[,] matriz1 = new int[3, 3];
      int[,] matriz2 = new int[3, 3];
      int[,] soma = new int[3, 3];

      LeMatriz(matriz1, matriz2);
      Soma(matriz1, matriz2, soma);


    }
  }
}
