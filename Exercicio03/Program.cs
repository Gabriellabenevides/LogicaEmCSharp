static void Main(string[] args)
{

    Console.WriteLine("Qual é o seu nome?");
    string nome = Console.ReadLine();
    Console.WriteLine("Qual é a sua idade?");
    int idade = int.Parse(Console.ReadLine());

    int resultado = 2050 - 2023;
    resultado = resultado + idade;

    Console.WriteLine($"Sua idade em 2050 será {resultado} anos");
}