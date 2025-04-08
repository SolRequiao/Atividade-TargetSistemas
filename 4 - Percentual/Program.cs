using System.Globalization;

namespace _4___Percentual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var faturamentos = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

            double total = 0;

            foreach (var valor in faturamentos.Values)
            {
                total += valor;
            }

            Console.WriteLine("Percentual de representacao por estado:\n");

            foreach (var estado in faturamentos)
            {
                double percentual = (estado.Value / total) * 100;
                Console.WriteLine($"{estado.Key}: {percentual.ToString("F2", CultureInfo.InvariantCulture)}%");
            }

            Console.WriteLine($"\nFaturamento total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
