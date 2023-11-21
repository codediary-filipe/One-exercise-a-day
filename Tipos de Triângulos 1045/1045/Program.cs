using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lendo os nosso valores: A B C:
            string[] Lados = Console.ReadLine().Split(' ');

            //Atribuído os nosso valores as nossas variáveis:
            double A = double.Parse(Lados[0], CultureInfo.InvariantCulture);
            double B = double.Parse(Lados[1], CultureInfo.InvariantCulture);
            double C = double.Parse(Lados[2], CultureInfo.InvariantCulture);

            //Criando um novo obj do tipo Triângulo:
            Triangulo triangulo = new(A, B, C);
            //retornando a nossa mensagem pré-definida em m nosso exercício.
            Console.WriteLine(triangulo.RetorneTriangulo());
        }
    }
}
