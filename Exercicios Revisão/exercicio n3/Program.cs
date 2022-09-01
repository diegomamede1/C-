using System;
namespace ExercResolv
{
  class Program
  {
    static double LeRealNaoNegativo()
    {
      double numero;
      Console.Write("Informe um número real não negativo: ");
      numero = Convert.ToDouble(Console.ReadLine());
      while (numero < 0)
      {
        Console.WriteLine("Número inválido!");
        Console.Write("Informe um número real não negativo: ");
        numero = Convert.ToDouble(Console.ReadLine());
      }
      return numero;
    }
    static void Main(string[] args)
    {
      double valor = LeRealNaoNegativo();
      Console.WriteLine("Número real não negativo: {0}", valor);
    }
  }
}