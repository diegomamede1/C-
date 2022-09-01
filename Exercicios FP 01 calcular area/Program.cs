using System;

namespace aula1;

    class Program
    {
        static void Main(string[] args)
        {
          double raio;
          double area;
          Console.Write("Raio: ");
          raio = Convert.ToDouble(Console.ReadLine ());
          area = 3.1415 * raio * raio;
          Console.Write("Area: ");
          Console.WriteLine(area);
        }
    }

