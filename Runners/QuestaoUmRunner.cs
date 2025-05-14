using TargetTestApp.Solvers.Questao01;

namespace TargetTestApp.Runners
{
    class QuestaoUmRunner
    {
        public static void Executar()
        {
            Console.WriteLine("Questão 01:");

            var somaService = new SomaService();
            int resultado = somaService.CalcularSoma();
            Console.WriteLine($"Resultado da soma: {resultado}");
        }

    }
}
