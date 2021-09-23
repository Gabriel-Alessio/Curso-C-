using System;

namespace ConsoleApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());

      int[] valor;
      valor = new int[n];
      string[] v = Console.ReadLine().Split(' ');
      int posicao = 0;

      for (var i = 0; i < n; i++)
      {
        valor[i] = int.Parse(v[i]); // atribui valores no vetor

        if(double.Parse(v[i]) % 2 == 0)
        {
          Console.Write(valor[i] + " ");
          posicao++;
        }
      }
      Console.WriteLine();
      Console.WriteLine(posicao);
    }
  }
}
