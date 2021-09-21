using System;

namespace Somasimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            int A, B, soma;

        
            Console.Write("Informe o 1º número -> ");
            
            //Lê o valor digitado
            A = int.Parse(Console.ReadLine());

            Console.Write("Informe o 2º número -> ");
            B = int.Parse(Console.ReadLine());

            soma = A + B;     
            
            //Imprimi o resultado
            Console.WriteLine("SOMA = " + soma);

            
        }
    }
}
