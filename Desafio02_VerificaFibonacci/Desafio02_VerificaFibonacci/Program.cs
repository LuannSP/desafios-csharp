using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int numero) || numero < 0)
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro positivo.");
            return;
        }

        bool pertence = VerificaFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool VerificaFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        while (a <= numero)
        {
            if (a == numero)
                return true;

            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}
