using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;


namespace _3___Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "3 - Vetor",
                "dados.json"
            );


            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Arquivo dados.json não encontrado.");
                return;
            }

            string json = File.ReadAllText(caminhoArquivo);
            List<Faturamento> dados = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            
            var diasComFaturamento = dados.Where(d => d.Valor > 0).ToList();

            if (dados == null)
            {
                Console.WriteLine("Valor null");
            }

            if (diasComFaturamento.Count == 0)
            {
                Console.WriteLine("Nenhum dia com faturamento registrado.");
                return;
            }

            double menor = diasComFaturamento.Min(d => d.Valor);
            double maior = diasComFaturamento.Max(d => d.Valor);
            double media = diasComFaturamento.Average(d => d.Valor);
            int diasAcimaMedia = diasComFaturamento.Count(d => d.Valor > media);

            Console.WriteLine($"Menor faturamento do mês: R$ {menor:F2}");
            Console.WriteLine($"Maior faturamento do mês: R$ {maior:F2}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaMedia}");
        }
    }
}
