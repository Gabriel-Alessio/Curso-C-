using System;

namespace Matriz_Atv_1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] aux = Console.ReadLine().Split(' ');
      int m = int.Parse(aux[0]);
      int n = int.Parse(aux[1]);

      int[,] mat = new int[m, n];

      for (var i = 0; i < m; i++)
      {
        aux = Console.ReadLine().Split(' ');
        for (var j = 0; j < n; j++)
        {
          mat[i, j] = int.Parse(aux[j]); //adiciona os valores nas linha i e na linha j
        }
      }
      Console.WriteLine("VALORES NEGATIVOS: ");
      for (var i = 0; i < m; i++)
      {
        for (var j = 0; j < n; j++)
        {
          if (mat[i, j] < 0)
          {
            Console.WriteLine(mat[i, j]); 
          }
        }
      }
    }
  }
}
