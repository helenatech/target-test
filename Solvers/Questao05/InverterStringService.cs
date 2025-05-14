namespace TargetTestApp.Solvers.Questao05
{
    class InverterStringService
    {
        public void Resolver()
        {
            string original = "Target Sistemas";
            string invertida = InverterString(original);

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Invertida: {invertida}");
        }

        private string InverterString(string texto)
        {
            char[] caracteres = new char[texto.Length];
            int j = 0;

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                caracteres[j] = texto[i];
                j++;
            }

            return new string(caracteres);
        }
    }
}
