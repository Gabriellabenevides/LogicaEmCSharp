class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escreva seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Escreva seu saldo: ");
        float saldo = float.Parse(Console.ReadLine());

        Console.WriteLine($"Seu nome é {nome} e seu saldo é {saldo} R$");

        int resposta = 0;

        while (resposta != 2)
        {
            Console.WriteLine("1.Executar Novamente \n2. Sair");
            resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Console.WriteLine($"Seu nome é {nome} e seu saldo é {saldo} R$");
            }
        }

        Console.WriteLine("Obrigada!");
    }
}
