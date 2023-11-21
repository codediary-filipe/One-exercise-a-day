# Tipos de Triângulos
> Desafio Beecrowd | Problema 1045

### Proposta
A ideia é ler três valores de ponto flutuante (A, B e C), ordená-los em ordem decrescente, e determinar o tipo de triângulo formado por esses lados.

### Descrição do Problema
Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que esses três lados formam, seguindo as regras abaixo:

- Se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO;
- Se A² = B² + c², apresente a mensagem: TRIANGULO RETANGULO;
- Se A² > B² + c², apresente a mensagem: TRIANGULO OBTUSANGULO;
- Se A² < B² + c², apresente a mensagem: TRIANGULO ACUTANGULO;
- Se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO;
- Se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES;

### Saída
> Imprima todas as classificações do triângulo especificado na entrada.

| Entrada | Saída                                      |
|---------|--------------------------------------------|
| 7.0 5.0 7.0 | TRIANGULO ACUTANGULO<br>TRIANGULO ISOSCELES |
| ...     | ...                                        |