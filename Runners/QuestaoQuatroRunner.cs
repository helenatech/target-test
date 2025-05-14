using TargetTestApp.Solvers.Questao04;

namespace TargetTestApp.Runners
{
    class QuestaoQuatroRunner
    {
        public static void Executar()
        {
            Console.WriteLine("Questão 04:");
            var solver = new FaturamentoEstadoService();
            solver.Resolver();
        }
    }
}
