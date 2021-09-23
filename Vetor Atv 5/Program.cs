using System;
using System.Globalization;

namespace Vetor_Atv_5
{
  class Program
  {
    static void Main(string[] args)
    {
      //5) Fazer um programa para ler um vetor de N números inteiros.Em seguida, mostrar na tela a média aritmética somente
      //dos números pares lidos.

      int n = int.Parse(Console.ReadLine());
      int[] vetor = new int[n];
      string[] valor = Console.ReadLine().Split(' ');
      double soma = 0.0, media;
      int count = 0;

      for (int i = 0; i < n; i++)
      {
        vetor[i] = int.Parse(valor[i]); // atribui valores no vetor

        if (vetor[i] % 2 == 0)
        {
          soma += vetor[i]; // soma todos os numeros pares 
          count++; // conta todos os numeros pares 
        }
      }
      media = soma / count; // faz a media dos numeros pares com a soma deles dividido pela contagem
      Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
  }
}
