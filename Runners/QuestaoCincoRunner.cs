using TargetTestApp.Solvers.Questao05;

namespace TargetTestApp.Runners
{
    class QuestaoCincoRunner
    {
        public static void Executar()
        {
            Console.WriteLine("Questão 05:");

            var solver = new InverterStringService();
            solver.Resolver();
        }
    }
}
