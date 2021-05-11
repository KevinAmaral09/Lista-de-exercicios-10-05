using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Escreva o {i + 1}º nome de pessoas numa lista de dez pessoas");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Escreva o nome de uma pessoa qualquer, sem que esteja na lista ");
            string nome_aleatorio = Console.ReadLine();

            foreach (var item in nomes)
            {
                if (item == nome_aleatorio)
                {
                    Console.WriteLine("Essa pessoa está na lista!");
                    
                }
                else
                {
                    Console.WriteLine("Essa pessoa não está na lista!");
                    break;
                }
            }
        }
    }
}
        
