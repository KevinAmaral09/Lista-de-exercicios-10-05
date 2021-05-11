using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao posto, você deseja colocar:  (A) Alcool   ou   (G) Gasolina ?");
            String tipo = Console.ReadLine();

            Console.WriteLine("Quantos litros você quer abastecer?");
            int litros = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case "a":
                    if (litros <= 20)
                    {
                        double desconto = 98 - 2.94;
                        double preco = desconto;
                        Console.WriteLine("Você terá que pagar : " + preco);
                        
                    }
                    else
                    {
                        double desconto = 102 -5.1;
                        double preco = desconto;
                        Console.WriteLine("Você terá que pagar : " + preco);
                    }
                    break;
                    
                    case "g":
                    if (litros <= 20)
                    {
                        double desconto = 106 - 4.24;
                        double preco = desconto;
                        Console.WriteLine("Você terá que pagar : " + preco);
                        
                    }
                    else
                    {
                        double desconto = 111 - 6.66;
                        double preco = desconto;
                        Console.WriteLine("Você terá que pagar : " + preco);
                    }
                    break;
                    
                default:
                    break;
            }
            
        }
    }
}