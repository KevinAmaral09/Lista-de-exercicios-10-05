using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] QuantNumeros = new int[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"escreva o {i + 1}º");
                QuantNumeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(QuantNumeros);

               Console.WriteLine($"O menor é: {QuantNumeros[0]}"); 
               Console.WriteLine($"O maior é: {QuantNumeros[9]}"); 
        }
    }
}
