using System;

namespace Vetor_Atv_6
{
  class Program
  {
    static void Main(string[] args)
    {
      //6) Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades.Depois, mostrar na tela o nome
      //da pessoa mais velha.

      int n = int.Parse(Console.ReadLine());

      string[] nomes = new string[n];
      int[] idades = new int[n];
      int idadeMaior = 0;
      string maisVelho = "";

      for (int i = 0; i < n; i++)
      {
        string[] aux = Console.ReadLine().Split(' ');
        nomes[i] = aux[0];
        idades[i] = int.Parse(aux[1]);

        if (i == 0)
        {
          idadeMaior = idades[i];
        }
        if (idades[i] > idadeMaior)
        {
          idadeMaior = idades[i];
          maisVelho = nomes[i];
        }
      }
      Console.WriteLine("Pessoa mais velha: " + maisVelho);
    }
  }
}
