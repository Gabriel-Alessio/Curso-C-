using System;
using System.Globalization;

namespace Vetor_Atv_4
{
  class Program
  {
    static void Main(string[] args)
    {
      //4) Fazer um programa para ler um vetor de N números reais.Em seguida, mostrar na tela a média aritmética de todos
      //elementos.Depois mostrar todos os elementos do vetor que estejam abaixo da média.

      int n = int.Parse(Console.ReadLine());
      double[] vetor = new double[n];
      double soma = 0;

      string[] valor = Console.ReadLine().Split(' ');

      for (int i = 0; i < n; i++)
      {
        vetor[i] = double.Parse(valor[i], CultureInfo.InvariantCulture); // atribui valores no vetor
        soma += vetor[i];
      }
      double media = soma / n;
      Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

      for (int i = 0; i < n; i++)
      {
        if (vetor[i] < media)
        {
          Console.WriteLine(valor[i]);
        }
      }
    }
  }
}
