class Program
{
    static void Main(string[] args)
    {
        string nome, nomeProduto;
        float saldo, valorProduto;

        Console.WriteLine("**** Programa de Pagamentos ****");
        Console.WriteLine("Qual o seu nome?");
        nome = Console.ReadLine();
        Console.WriteLine("Qual o seu saldo?");
        saldo = float.Parse(Console.ReadLine());
        Console.WriteLine("Qual o nome do produto?");
        nomeProduto = Console.ReadLine();
        Console.WriteLine("Qual o valor do produto?");
        valorProduto = float.Parse(Console.ReadLine());

        Console.WriteLine($"Olá, {nome}! Você deseja comprar o produto {nomeProduto} no valor de {valorProduto} R$? [S/N]");

        string resposta = Console.ReadLine();
        if (resposta == "S")
        {
            if (saldo >= valorProduto)
            {
                saldo -= valorProduto;
                Console.WriteLine($"{nome} Você comprou o {nomeProduto} e o seu saldo é {saldo} R$ ");
            }
            else
            {
                Console.WriteLine("Seu saldo é insuficiente!");
            }
        }
        else if (resposta == "N")
        {
            Console.WriteLine("Obrigada por visitar nossa loja!");

        }
        else
        {
            Console.WriteLine("Resposta inválida!");
        }



        Console.ReadLine();

    }
}