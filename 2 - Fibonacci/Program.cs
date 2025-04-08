namespace _2___Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int numero;

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                int a = 0;
                int b = 1;
                bool pertence = false;

                while (a <= numero)
                {
                    if (a == numero)
                    {
                        pertence = true;
                        break;
                    }

                    int temp = a;
                    a = b;
                    b = temp + b;
                }

                if (pertence)
                {
                    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
                }
                else
                {
                    Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
                }
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }

        }
    }
}
