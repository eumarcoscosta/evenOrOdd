using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero, i, valorInserido = 0, imparPositivo, imparNegativo, parPositivo, parNegativo, nulo;

            Console.WriteLine("Insira o numero abaixo para a quantidade de vezes que o programa irá ler: ");

            numero = int.Parse(Console.ReadLine());

            for (i = 0; i < numero; i++)
            {
                valorInserido = int.Parse(Console.ReadLine());

                if (valorInserido < 0 & valorInserido % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (valorInserido < 0 & valorInserido % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (valorInserido > 0 & valorInserido % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (valorInserido > 0 & valorInserido % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }

            }

        }
    }
}
