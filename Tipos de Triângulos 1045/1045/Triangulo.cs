using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise
{
    public class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        //Construtor da classe Triangulo
        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            //Chamando a função que cria a nossa lista e coloca os valores em ordem Decrescente:
            AdicionarLados();
        }

        public void AdicionarLados()
        {
            //Criada a nossa lista:
            List<double> Lados = new() { A, B, C };
            Lados = Lados.OrderByDescending(x => x).ToList();
            /*.OrderByDescending(x => x):
              Ordena a lista em ordem decrescente com base na expresão lambda (x => x) que  representa cada elemento da lista (denotado por x).
              
              .ToList():
                Converter a sequência ordenada de elementos de volta para uma lista.
            */
            //Reatribuíndo os valores:
            A = Lados[0];
            B = Lados[1];
            C = Lados[2];
        }
        //Função que retorna a mensagem pré-definida em nossa exercício:
        public string RetorneTriangulo()
        {
            StringBuilder Mensagem = new();

            //Este método verifica as propriedades do triângulo e constrói uma mensagem com base nessas verificações.
            if (A >= B + C)
            {
                return "NAO FORMA TRIANGULO";
            }
            else
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Mensagem.AppendLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Mensagem.AppendLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Mensagem.AppendLine("TRIANGULO ACUTANGULO");
                }
            }
            if (A == B && B == C)
            {
                Mensagem.AppendLine("TRIANGULO EQUILATERO");
            }
            if (A == B || B == C || C == A)
            {
                Mensagem.AppendLine("TRIANGULO ISOSCELES");
            }
            return Mensagem.ToString();
        }
    }
}