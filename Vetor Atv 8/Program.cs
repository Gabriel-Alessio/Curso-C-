using System;
using System.Globalization;

namespace Vetor_Atv_8
{
  class Program
  {
    static void Main(string[] args)
    {
      //8) Tem - se um conjunto de dados contendo a altura e o sexo(M, F) de N pessoas.Fazer um programa que calcule e escreva:
      //   a maior e a menor altura do grupo
      //   a média de altura das mulheres
      //   o número de homens

      int n = int.Parse(Console.ReadLine());

      double[] altura = new double[n];
      char[] sexo = new char[n];
      double maiorAltura = 0.0, menorAltura = 0.0, AlturaMediaM = 0.0;
      int countM = 0, countF = 0;

      // atruibui os valores
      for (var i = 0; i < n; i++)
      {
        string[] aux = Console.ReadLine().Split(' ');

        altura[i] = double.Parse(aux[0], CultureInfo.InvariantCulture);
        sexo[i] = char.Parse(aux[1]);

        // sempre iniciara com a primeira altura informada
        if (i == 0)
        {
          maiorAltura = altura[i];
          menorAltura = altura[i];
        }
        // sempre que for informada uma nova altura, verifica se essa nova altura é maior que a maior altura atual, caso sejá, vai ser a nova altura maior
        if (altura[i] > maiorAltura)
        {
          maiorAltura = altura[i];
        }
        // sempre que for informada uma nova altura, verifica se essa nova altura é menor que a menor altura atual, caso sejá, vai ser a nova altura menor
        if (altura[i] < menorAltura)
        {
          menorAltura = altura[i];
        }

        if (sexo[i] == 'F')
        {
          AlturaMediaM += altura[i]; // soma todas as alturas das mulheres
          countF++; // faz a contagem da quantidade de mulheres 
        }

        if (sexo[i] == 'M')
        {
          countM++; // faz a contagem da quantidade de homens
        }
      }

      var media= AlturaMediaM / countF; // faz a media das alturas das mulheres, soma das alturas dividido pela quantidade de mulheres

      Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Numero de homens = " + countM);
    }
  }
}
