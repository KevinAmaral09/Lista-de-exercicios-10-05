using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, qual o nome do produto?");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Qual a quantidade do produto?");
            int quant = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual o preço de um produto?");
            float preco = int.Parse(Console.ReadLine());

            if (quant <= 5)
            {
                double total = quant * preco;
                double desconto = preco * 2 / 100;
                double total_pagar = total - desconto; 
                Console.WriteLine("O valor total é de: " + total + "temos um desconto para você de 2% de desconto , o valor final foi: " + total_pagar);
            }
            else
            {
                if (quant > 5 && quant <= 10)
                {
                    double total = quant * preco;
                    double desconto = preco * 3 / 100;
                    double total_pagar = total - desconto; 
                    Console.WriteLine("O valor total é de: " + total + "temos um desconto para você de 3% de desconto , o valor final foi: " + total_pagar);
                }
                else
                {
                    double total = quant * preco;
                    double desconto = preco * 5 / 100;
                    double total_pagar = total - desconto; 
                    Console.WriteLine("O valor total é de: " + total + "temos um desconto para você de 5% de desconto , o valor final foi: " + total_pagar); 
                }
            }
            
        }
    }
}
