using System;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "faturamento.json");


        if (!File.Exists(jsonPath))
        {
            Console.WriteLine("Arquivo de faturamento não encontrado.");
            return;
        }

        string jsonString = File.ReadAllText(jsonPath);
        double[] faturamentoDiario = JsonSerializer.Deserialize<double[]>(jsonString);

        double menorFaturamento = faturamentoDiario.Where(f => f > 0).Min();
        double maiorFaturamento = faturamentoDiario.Max();
        double mediaMensal = faturamentoDiario.Where(f => f > 0).Average();
        int diasAcimaDaMedia = faturamentoDiario.Count(f => f > mediaMensal);

        Console.WriteLine($"Menor faturamento: {menorFaturamento:C}");
        Console.WriteLine($"Maior faturamento: {maiorFaturamento:C}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
