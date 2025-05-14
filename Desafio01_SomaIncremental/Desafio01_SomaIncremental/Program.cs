using System;

class Program
{
    static void Main(string[] args)
    {
        const int indice = 13;
        int soma = 0, k = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }

        Console.WriteLine($"Valor final de soma: {soma}");
    }
}
