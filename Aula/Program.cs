using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o destino da viagem?");
            string destino = Console.ReadLine(); 
            Console.WriteLine("Qual é o valor da passagem?");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas pessoas vão viajar?");
            int pessoas = int.Parse(Console.ReadLine());

            double valorOriginal = valor * pessoas;
            double valorPrimeiroDesconto;
            double valorSegundoDesconto;

            if (pessoas < 2)
            {
                Console.WriteLine("Esta modalidade é restrita a compras a partir de 2 passagens.");
            }

            else
            {
                if (valor <= 1000)
                    valorPrimeiroDesconto = valorOriginal - (valorOriginal * 0.1);

                else
                    valorPrimeiroDesconto = valorOriginal - (valorOriginal * 0.15);


                if (pessoas <= 10)

                    valorSegundoDesconto = valorPrimeiroDesconto - (valorPrimeiroDesconto * 0.05);

                else
                {
                    double percentualDescontoAgregado = pessoas * 0.005;

                    if (percentualDescontoAgregado > 0.25)
                        percentualDescontoAgregado = 0.25;

                    valorSegundoDesconto = valorPrimeiroDesconto - (valorPrimeiroDesconto * percentualDescontoAgregado);
                }

                Console.WriteLine($"Seu  destino é {destino}, a quantidade de pessoas é {pessoas} e o valor final é: {valorSegundoDesconto} R$");
            }
        }
    }
}