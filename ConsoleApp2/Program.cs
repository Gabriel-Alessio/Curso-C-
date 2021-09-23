using System;

namespace ConsoleApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      //2) Faça um programa que leia N números inteiros e armazene-os em um vetor.Em seguida, mostre na tela:
      //-todos os números pares
      //-a quantidade de números pares
      int n = int.Parse(Console.ReadLine());

      int[] vetor = new int[n];
      string[] valor = Console.ReadLine().Split(' ');
      int posicao = 0;

      for (var i = 0; i < n; i++)
      {
        vetor[i] = int.Parse(valor[i]); // atribui valores no vetor

        if(double.Parse(valor[i]) % 2 == 0)
        {
          Console.Write(vetor[i] + " ");
          posicao++;
        }
      }
      Console.WriteLine();
      Console.WriteLine(posicao);
    }
  }
}
