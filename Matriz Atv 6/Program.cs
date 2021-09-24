using System;
using System.Globalization;

namespace Matriz_Atv_6
{
  class Program
  {
    static void Main(string[] args)
    {
      //6) Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:

      int n = int.Parse(Console.ReadLine());

      double[,] mat = new double[n, n];

      for (var i = 0; i < n; i++)
      {
        string[] aux = Console.ReadLine().Split(' ');
        for (var j = 0; j < n; j++)
        {
          mat[i, j] = double.Parse(aux[j], CultureInfo.InvariantCulture); //adiciona os valores nas linhas i e nas colunas j
        }
      }
      //a) calcular e imprimir a soma de todos os elementos positivos da matriz.

      double soma = 0;
      for (var i = 0; i < n; i++)
      {
        for (var j = 0; j < n; j++)
        {
          if (mat[i, j] > 0)
          {
            soma += mat[i, j];
          }
        }
      }
      Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

      //b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.

      Console.Write("INFORME A LINHA QUE DESEJAR VISUALIZAR: ");
      int linha = int.Parse(Console.ReadLine());

      for (var i = linha; i == linha; i++)
      {
        Console.Write("LINHA ESCOLHIDA: ");
        for (var j = 0; j < n; j++)
        {
          Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
      }
      Console.WriteLine();

      //c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.

      Console.Write("INFORME A COLUNA QUE DESEJAR VISUALIZAR: ");
      int coluna = int.Parse(Console.ReadLine());

      Console.Write("COLUNA ESCOLHIDA: ");
      for (var i = 0; i < n; i++)
      {
        for (var j = coluna; j == coluna; j++)
        {
          Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
      }
      Console.WriteLine();

      //d) imprimir os elementos da diagonal principal da matriz.

      Console.Write("DIAGONAL PRINCIPAL: ");
      for (var i = 0; i < n; i++)
      {
        Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
      }
      Console.WriteLine();

      //e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.

      Console.WriteLine("MATRIZ ALTERADA: ");
      for (var i = 0; i < n; i++)
      {
        for (var j = 0; j < n; j++)
        {
          if (mat[i, j] < 0)
          {
            var divisao = mat[i, j] * mat[i, j];
            mat[i, j] = divisao;
          }
          Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
        Console.WriteLine();
      }
    }
  }
}