using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Faturamento mensal por estado
        Dictionary<string, double> faturamentoEstados = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        // Calcular o faturamento total
        double totalFaturamento = 0;
        foreach (var faturamento in faturamentoEstados.Values)
        {
            totalFaturamento += faturamento;
        }

        Console.WriteLine($"Faturamento total: R$ {totalFaturamento:F2}");

        // Calcular o percentual de cada estado
        foreach (var estado in faturamentoEstados)
        {
            double percentual = (estado.Value / totalFaturamento) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}
