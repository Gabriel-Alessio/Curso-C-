using System;
using System.Globalization;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      //1) Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número 
      //do vetor(supor não haver empates).Mostrar também a posição do maior elemento
    
      int n = int.Parse(Console.ReadLine());
      double[] vetor = new double[n]; 
      double maior = 0;

      string[] valor = Console.ReadLine().Split(' ');
      int posicao = 0;

      for (int i = 0; i < n; i++)
      {
        vetor[i] = double.Parse(valor[i], CultureInfo.InvariantCulture); // atribui valores no vetor

        // vai atribuir o primeiro valor na variavel maior para depois ser comparada
        if (i == 0)
        {
          maior = double.Parse(valor[i], CultureInfo.InvariantCulture);
        }
        // vai verificar o primeiro valor atribuido com os outros para verificar se tera um maior
        if (double.Parse(valor[i], CultureInfo.InvariantCulture) > maior)
        {
          maior = double.Parse(valor[i], CultureInfo.InvariantCulture);
          posicao = i;
        }
      }
      Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
      Console.WriteLine(posicao);
    }
  }
}