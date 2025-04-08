namespace _1___Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 13, soma = 0, k = 0;
            while (k < indice)
            {
                k++;
                soma = soma + k;
            }

            Console.WriteLine("Valor final de SOMA=" + soma);

        }
    }
}
