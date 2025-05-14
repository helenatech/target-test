namespace TargetTestApp.Solvers.Questao01
{
    class SomaService
    {
        public int CalcularSoma()
        {
            int INDICE = 13,
                SOMA = 0,
                K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            return SOMA;
        }
    }
}
