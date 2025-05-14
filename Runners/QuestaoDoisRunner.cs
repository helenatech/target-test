using TargetTestApp.Solvers.Questao02;

namespace TargetTestApp.Runners
{
    class QuestaoDoisRunner
    {
        public static void Executar()
        {
            Console.WriteLine("Questão 02:");

            var fibonacciService = new FibonacciService();

            Console.Write("Digite um número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                bool pertence = fibonacciService.VerificarSePertence(numero);
                Console.WriteLine(pertence
                    ? $"O número {numero} pertence à sequência de Fibonacci."
                    : $"O número {numero} NÃO pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }
    }
}