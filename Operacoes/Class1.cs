namespace Operacoes
{
    public class Class1
    {
        public static void Adicao (float n1, float n2)
        {
            Console.WriteLine("Resultado: " + (n1 + n2) + "\r\n");
        }

        public static void Subtracao(float n1, float n2)
        {
            Console.WriteLine("Resultado: " + (n1 - n2) + "\r\n");
        }

        public static void Multiplicacao(float n1, float n2)
        {
            Console.WriteLine("Resultado: " + (n1 * n2) + "\r\n");
        }

        public static void Divisao(float n1, float n2)
        {
            if (n2 != 0)
            {
                Console.WriteLine("Resultado: " + (n1 / n2) + "\r\n");
            }
            else
            {
                Console.WriteLine("Não é possível dividir por 0\r\n");
            }
        }
    }
}