using System;

namespace Matriz_Atv_7
{
  class Program
  {
    static void Main(string[] args)
    {
      int m = int.Parse(Console.ReadLine());
      int n = int.Parse(Console.ReadLine());

      int[,] mat = new int[m, n];

      for (var i = 0; i < m; i++)
      {
        string [] aux = Console.ReadLine().Split(' ');
        for (var j = 0; j < n; j++)
        {
          mat[i, j] = int.Parse(aux[j]); //adiciona os valores nas linhas i e nas colunas j na matriz 1
        }
      }

      int fila = int.Parse(Console.ReadLine());

      // como nossa matriz comeca na linha 0, vamos decrementar o valor da fila
      fila--;

      // passo 1: vamos salvar o ultimo da fila escolhida
      int ultimoDaFila = mat[fila, n - 1];

      // passo 2: vamos mover todos da fila (menos o ultimo) para a direita,
      // mas teremos que fazer isso da direita para a esquerda (contagem decrescente)
      for (int j = n - 1; j > 0; j--)
      {
        mat[fila, j] = mat[fila, j - 1];
      }

      // passo 3: agora vamos armazenar o ultimo na primeira posicao da fila
      mat[fila, 0] = ultimoDaFila;


      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          Console.Write(mat[i, j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
