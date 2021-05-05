using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            double X1;
            double X2;
            double Delta;

            Console.Write("Digite o Valor de A: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor de B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor de C: ");
            C = double.Parse(Console.ReadLine());

            Delta = Math.Pow(B, 2) - (4 * A * C);

            if (A == 0)
            {
                Console.WriteLine("Não é uma equação de segundo grau!");
                Environment.Exit(-1);
            }

            if (Delta < 0)
            {
                Console.WriteLine($"Como delta = {Delta:N2}, a equação não possui raízes reais!");
                Environment.Exit(-1);
            }

            X1 = (-B + Math.Sqrt(Delta)) / 2 * A;
            X2 = (-B - Math.Sqrt(Delta)) / 2 * A;

            Console.WriteLine();
            Console.Write("O resultado de x1 é: ");
            Console.WriteLine(Math.Round(X1, 2));

            Console.Write("O resultado de x2 é: ");
            Console.WriteLine(Math.Round(X2, 2));
        }
    }
}
