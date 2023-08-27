class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Há quantos anos você faz natação?");
        int anos = int.Parse(Console.ReadLine());

        if (anos < 3)
        {
            Console.WriteLine("Você é iniciante!");
        }
        else if (anos >= 3 && anos <= 5)
        {
            Console.WriteLine("Você é intermediário");
        }
        else

        {
            Console.WriteLine("Você é avançado");
        }
    }
}