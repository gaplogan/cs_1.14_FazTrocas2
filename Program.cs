using System;

namespace cs_1._14_FazTrocas2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.Clear();

            //valida os números para garantir que sejam diferentes entre si
            do
            {
                Console.Write("Digite o primeiro número: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                n2 = double.Parse(Console.ReadLine());
            } while (n1 == n2); //fim a entrada/validação dos números

            Console.WriteLine();
            Console.WriteLine("Valores antes das trocas: ");
            Console.WriteLine($"Primeiro número: {n1}");
            Console.WriteLine($"Segundo número: {n2}");
            
            //{Faz as trocas com adições e subtrações}
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            
            //{Apresenta os resultados}         
            Console.WriteLine();
            Console.WriteLine("Valores depois das trocas: ");
            Console.WriteLine($"Primeiro número: {n1}");
            Console.WriteLine($"Segundo número: {n2}");
        }
    }
}
