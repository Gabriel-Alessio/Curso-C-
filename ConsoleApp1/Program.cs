﻿using System;
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
      double[] valor;
      double maior = 0;

      valor = new double[n];

      string[] v = Console.ReadLine().Split(' ');
      int posicao = 0;

      for (int i = 0; i < n; i++)
      {
        valor[i] = double.Parse(v[i], CultureInfo.InvariantCulture); // atribui valores no vetor

        // vai atribuir o primeiro valor na variavel maior para depois ser comparada
        if (i == 0)
        {
          maior = double.Parse(v[i], CultureInfo.InvariantCulture);
        }
        // vai verificar o primeiro valor atribuido com os outros para verificar se tera um maior
        if (double.Parse(v[i], CultureInfo.InvariantCulture) > maior)
        {
          maior = double.Parse(v[i], CultureInfo.InvariantCulture);
          posicao = i;
        }
      }
      Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
      Console.WriteLine(posicao);
    }
  }
}