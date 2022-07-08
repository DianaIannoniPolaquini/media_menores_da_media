using System;

namespace VETOR_MEDIA_MENORMEDIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double[] v = new double[x];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < x; i++)
            {
                v[i] = double.Parse(s[i]);
            }


            int cont = 0;
            double soma = 0;
            for (int i = 0; i < x; i++)
            {
                cont++;
                soma += v[i];
            }

            double media = soma / cont;
            Console.WriteLine($"Média: {media}.");

            for (int i = 0; i < x; i++)
            {
                if (v[i] < media)
                {
                    double abaixo = v[i];
                    Console.WriteLine(abaixo);
                }
            }

        }
    }
}
