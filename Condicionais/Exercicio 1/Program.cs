using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, qual seu nome?");
            Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Me informe por favor seu ano de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Qual é o ano atual?");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int resultado = anoAtual - nascimento;

            if (resultado > 16)
            {
                Console.WriteLine("Você já pode votar, tenha consciência do seu voto!!");
            }
            else 
            {
                Console.WriteLine("Desculpa, você não pode votar !!");
            }

            
        }
    }
}
