using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_CSharp___Análise_de_Números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int quantidadePositivos = 0;
            int quantidadeNegativos = 0;

            Console.WriteLine("Digite 5 números: ");

            List<int> Valores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                Valores.Add(valor);

                if (Valores[i] % 2 == 0)
                {
                    quantidadePares += 1;

                    if (Valores[i] > 0)
                    {
                        quantidadePositivos += 1;
                    }
                    else if (Valores[i] < 0)
                    {
                        quantidadeNegativos += 1;
                    }
                }
                else
                {
                    if (Valores[i] % 2 != 0)
                    {
                        quantidadeImpares += 1;
                        if (Valores[i] > 0)
                        {
                            quantidadePositivos += 1;
                        }
                        else if (Valores[i] < 0)
                        {
                            quantidadeNegativos += 1;
                        }
                    }
                }

            }

            Console.WriteLine("{0} par(es)", quantidadePares);
            Console.WriteLine("{0} impar(es)", quantidadeImpares);
            Console.WriteLine("{0} positivo(s)", quantidadePositivos);
            Console.WriteLine("{0} negativo(s)", quantidadeNegativos);

            Console.ReadKey();
        }
    }
}
