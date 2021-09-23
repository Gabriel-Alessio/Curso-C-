using System;

namespace Matriz_Atv_2
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
          mat[i, j] = int.Parse(aux[j]); //adiciona os valores nas linha i e na linha j
        }
      }
      for (var i = 0; i < n; i++)
      {
        var sum = 0;
        for (var j = 0; j < n; j++)
        {
          sum += mat[i, j]; // percorre todos os valores e vai fazer a soma de todas as linhas 
        }
        Console.WriteLine(sum);
      }
    }
  }
}
