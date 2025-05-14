using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    public class FaturamentoDia
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    static void Main(string[] args)
    {
        string caminhoArquivo = "faturamento.json";

        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine("Arquivo de faturamento não encontrado.");
            return;
        }

        string json = File.ReadAllText(caminhoArquivo);

        List<FaturamentoDia>? dados = JsonSerializer.Deserialize<List<FaturamentoDia>>(json);

        if (dados == null || dados.Count == 0)
        {
            Console.WriteLine("Nenhum dado encontrado no JSON.");
            return;
        }

        // Ignora dias com valor 0
        var diasValidos = dados.Where(d => d.valor > 0).ToList();

        double menor = diasValidos.Min(d => d.valor);
        double maior = diasValidos.Max(d => d.valor);
        double media = diasValidos.Average(d => d.valor);
        int diasAcimaMedia = diasValidos.Count(d => d.valor > media);

        Console.WriteLine($"Menor faturamento: R$ {menor:F2}");
        Console.WriteLine($"Maior faturamento: R$ {maior:F2}");
        Console.WriteLine($"Dias com faturamento acima da média ({media:F2}): {diasAcimaMedia}");
    }
}
