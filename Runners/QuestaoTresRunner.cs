using TargetTestApp.Solvers.Questao03;


namespace TargetTestApp.Runners
{
    class QuestaoTresRunner
    {
        public static void Executar()
        {
            Console.WriteLine("Questão 03:");

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string jsonPath = Path.Combine(basePath, "Data", "Faturamento.json");

            var solver = new FaturamentoService();
            solver.Resolver(jsonPath);
        }

    }
}
