using System;
// Exemplo de uso
Console.Write("Digite um número: ");
int num = int.Parse(Console.ReadLine());
if (Fibonacci.PertenceFibonacci(num))
{
    Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
}


