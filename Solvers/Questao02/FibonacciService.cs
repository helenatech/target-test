namespace TargetTestApp.Solvers.Questao02
{
    class FibonacciService
    {
        public bool VerificarSePertence(int numero)
        {
            if (numero < 0) return false;

            int a = 0, b = 1;

            while (a < numero)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a == numero;
        }
    }
}
