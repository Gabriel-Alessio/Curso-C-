using System;

namespace Matriz_Atv_4
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());

      int[,] mat = new int[n, n];

      for (var i = 0; i < n; i++)
      {
        string[] aux = Console.ReadLine().Split(' ');
        for (var j = 0; j < n; j++)
        {
          mat[i, j] = int.Parse(aux[j]); //adiciona os valores nas linhas i e nas colunas j
        }
      }
      int soma = 0;
      // os dois for percore todos os valores
      for (var i = 0; i < n; i++)
      {
        for (var j = 0; j < n; j++)
        {
          //forma alternativa 
          //if ((mat[i, j] == mat[0, 1]) || mat[i, j] == mat[0, 2] || mat[i, j] == mat[1, 2])

          if ((i == 0 && j == 1) || (i == 0 && j == 2) || (i == 1 && j == 2))
          {
            soma += mat[i, j];
          }
        }
      }
      Console.WriteLine(soma);
    }
  }
}
