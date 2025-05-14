using Newtonsoft.Json;

namespace TargetTestApp.Solvers.Questao03
{
    class FaturamentoService
    {
        public void Resolver(string caminhoArquivo)
        {
            string jsonData = File.ReadAllText(caminhoArquivo);
            var faturamento = JsonConvert.DeserializeObject<List<Faturamento>>(jsonData);

            var faturamentoValido = faturamento.Where(f => f.Valor > 0).ToList();
            var menorValor = faturamentoValido.Min(f => f.Valor);
            var maiorValor = faturamentoValido.Max(f => f.Valor);
            var mediaMensal = faturamentoValido.Average(f => f.Valor);
            var diasAcimaDaMedia = faturamentoValido.Count(f => f.Valor > mediaMensal);

            Console.WriteLine($"Menor valor de faturamento: {menorValor}");
            Console.WriteLine($"Maior valor de faturamento: {maiorValor}");
            Console.WriteLine($"Número de dias acima da média mensal: {diasAcimaDaMedia}");
        }
    }
}
