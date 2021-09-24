using System;

namespace Matriz_Atv_5
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] aux = Console.ReadLine().Split(' ');
      int m = int.Parse(aux[0]);
      int n = int.Parse(aux[1]);

      int[,] mat = new int[m, n];
      int[,] mat2 = new int[m, n];
      int[,] mat3 = new int[m, n];

      for (var i = 0; i < m; i++)
      {
        aux = Console.ReadLine().Split(' ');
        for (var j = 0; j < n; j++)
        {
          mat[i, j] = int.Parse(aux[j]); //adiciona os valores nas linhas i e nas colunas j na matriz 1
        }
      }

      for (var i = 0; i < m; i++)
      {
        aux = Console.ReadLine().Split(' ');
        for (var j = 0; j < n; j++)
        {
          mat2[i, j] = int.Parse(aux[j]); //adiciona os valores nas linhas i e nas colunas j na matriz 2
        }
      }

      for (var i = 0; i < m; i++)
      {
        for (var j = 0; j < n; j++)
        {
          mat3[i, j] = mat[i, j] + mat2[i, j];
          Console.Write(mat3[i, j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
