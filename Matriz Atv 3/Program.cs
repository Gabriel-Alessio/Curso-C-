using System;

namespace Matriz_Atv_3
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
      int maior = 0;
      // os dois for percore todos os valores
      for (var i = 0; i < n; i++)
      {
        for (var j = 0; j < n; j++)
        {
          if (j == 0)
          {
            maior = (mat[i, j]); // primeriro valor sempre vai ser 0 então ele sempre vai atribuir o primeiro valor a variavel maior
          }
          if (mat[i, j] > maior)
          {
            maior = (mat[i, j]); // caso um novo valor for maior que o valor maior digirado, atribuira esse novo valor para variavel 
          }
        }
        Console.WriteLine(maior);
      }
    }
  }
}
