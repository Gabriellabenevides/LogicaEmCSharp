class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual é o seu saldo?");
        float saldo = float.Parse(Console.ReadLine());
        int categoria = 0;

        if (saldo >= 0 && saldo <= 999)
        {
            categoria = 1;
        }
        else if (saldo > 999 && saldo < 9999)
        {
            categoria = 2;
        }
        else if (saldo >= 9.999)
        {
            categoria = 3;
        }

        switch (categoria)
        {
            case 1:
                Console.WriteLine("Popular");
                break;
            case 2:
                Console.WriteLine("Comum");
                break;
            case 3:
                Console.WriteLine("Premium");
                break;
        }
    }
}