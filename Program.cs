using System;
// Exemplo de uso
Console.Write("Digite um n�mero: ");
int num = int.Parse(Console.ReadLine());
if (Fibonacci.PertenceFibonacci(num))
{
    Console.WriteLine($"{num} pertence � sequ�ncia de Fibonacci.");
}
else
{
    Console.WriteLine($"{num} n�o pertence � sequ�ncia de Fibonacci.");
}


