using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string para inverter: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Você não digitou uma string válida.");
            return;
        }

        string invertedString = InverterString(input);
        Console.WriteLine($"String invertida: {invertedString}");
    }

    static string InverterString(string input)
    {
        char[] caracteres = new char[input.Length];
        int j = 0;

        // Loop de trás para frente, preenchendo o array com os caracteres invertidos
        for (int i = input.Length - 1; i >= 0; i--)
        {
            caracteres[j] = input[i];
            j++;
        }

        // Converter o array de volta para uma string
        return new string(caracteres);
    }
}
