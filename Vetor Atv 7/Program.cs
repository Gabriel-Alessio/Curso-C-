using System;
using System.Globalization;

namespace Vetor_Atv_7
{
  class Program
  {
    static void Main(string[] args)
    {
      //7) Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres. 
      //Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
      //considerando aprovados aqueles cuja média das notas seja maior ou igual a seis

      int n = int.Parse(Console.ReadLine());

      string[] nomes = new string[n];
      double[] n1 = new double[n];
      double[] n2 = new double[n];

      // atruibui os valores
      for (var i = 0; i < n; i++)
      {
        string[] aux = Console.ReadLine().Split(' ');

        nomes[i] = aux[0];
        n1[i] = double.Parse(aux[1], CultureInfo.InvariantCulture);
        n2[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);
      }

      // verificar todos os alunos com a nota maior que a media 
      Console.WriteLine("Alunos aprovados: ");
      for (var i = 0; i < n; i++)
      {
        var media = (n1[i] + n2[i]) / 2;
        if (media >= 6.0)
        {
          Console.WriteLine(nomes[i]);
        }
      }
    }
  }
}
