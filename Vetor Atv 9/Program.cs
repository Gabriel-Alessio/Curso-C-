using System;
using System.Globalization;

namespace Vetor_Atv_9
{
  class Program
  {
    static void Main(string[] args)
    {
      //9) Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa.Para isto, mandou digitar
      //um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda das mesmas.Fazer um
      //programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
      //   lucro < 10 %
      //   10 % ≤ lucro ≤ 20 %
      //   lucro > 20 %
      //Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o
      //lucro total.

      int n = int.Parse(Console.ReadLine());

      string[] produtos = new string[n];
      double[] precoCompra = new double[n];
      double[] precoVenda = new double[n];

      int countMenor10 = 0, countEntre10e20 = 0, countMenor20 = 0;
      double precoCompraTotal = 0, precoVendaTotal = 0;

      for (var i = 0; i < n; i++)
      {
        string[] aux = Console.ReadLine().Split(' ');

        produtos[i] = aux[0];
        precoCompra[i] = double.Parse(aux[1], CultureInfo.InvariantCulture);
        precoVenda[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);

        var lucro = precoVenda[i] - precoCompra[i];

        var porcentagemLucro = lucro / precoCompra[i] * 100.0; // calcula a porcentagem de lucros 

        // verifica a quantidade de lucros menor que 10%, entre 10% e 20% e maior q 20%
        if (porcentagemLucro < 10.0)
        {
          countMenor10++;
        }
        if (porcentagemLucro >= 10.0 && porcentagemLucro <= 20.0)
        {
          countEntre10e20++;
        }
        if (porcentagemLucro > 20)
        {
          countMenor20++;
        }

        precoCompraTotal += precoCompra[i]; // soma dos valores comprados 
        precoVendaTotal += precoVenda[i]; // soma dos valores vendidos
      }
      Console.WriteLine("Lucro abaixo de 10%: " + countMenor10);
      Console.WriteLine("Lucro entre 10% e 20%: " + countEntre10e20);
      Console.WriteLine("Lucro acima de 20%: " + countMenor20);
      Console.WriteLine("Valor total de compra: " + precoCompraTotal.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Valor total de venda: " + precoVendaTotal.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Lucro total: " + (precoVendaTotal - precoCompraTotal).ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
