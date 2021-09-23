using System;

namespace Vetor_Atv_3
{
  class Program
  {
    static void Main(string[] args)
    {
      //3) Faça um programa para ler dois vetores A e B, contendo N elementos cada.Em seguida, gere um terceiro vetor C onde
      //cada elemento de C é a soma dos elementos correspondentes de A e B.Imprima o vetor C gerado

      int n = int.Parse(Console.ReadLine());

      int[] vet1 = new int[n]; 
      int[] vet2 = new int[n]; 
      int[] vet3 = new int[n];

      string[] valor1 = Console.ReadLine().Split(' ');
      string[] valor2 = Console.ReadLine().Split(' ');

      for (int i = 0; i < n; i++)
      {
        vet1[i] = int.Parse(valor1[i]); // atribui os valores no vetor 1

        vet2[i] = int.Parse(valor2[i]); // atribui os valores no vetor 2

        vet3[i] = vet1[i] + vet2[i]; // faz a soma dos veteres 1 e 2 e atribui o resultado no vetor 3
        Console.Write(vet3[i] + " ");
      }
    }
  }
}
