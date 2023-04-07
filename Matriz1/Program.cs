using System;
using System.Globalization;

namespace Matriz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, IdadeMaior = 0, PosicaoIdadeMaior = 0;

            Console.WriteLine("Digite um número: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um nome e uma idade: ");
            string[] nomes = new string[N];
            int [] idades = new int[N];

            for (int i = 0; i < N; i++)
            {
                string [] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }
            for(int i = 0; i < N; i++)
            {
                if (idades[i] > IdadeMaior)
                {
                    IdadeMaior = idades[i];
                    PosicaoIdadeMaior = i;
                } 
            }

            Console.WriteLine("Pessoa mais velha: " + nomes[PosicaoIdadeMaior]);

        }
    }
}