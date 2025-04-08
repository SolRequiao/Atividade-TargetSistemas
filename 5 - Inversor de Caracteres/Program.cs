namespace _5___Inversor_de_Caracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string para inverter: ");
            string texto = Console.ReadLine();

            char[] invertido = new char[texto.Length];
            int j = 0;

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                invertido[j] = texto[i];
                j++;
            }

            string resultado = new string(invertido);
            Console.WriteLine("String invertida: " + resultado);
        }
    }
}
