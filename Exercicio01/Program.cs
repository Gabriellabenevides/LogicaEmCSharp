static void Main(string[] args)
{
    char primeiraLetraNome;
    string nome;
    float valor;
    double valorAlto;
    double valorAlto2;
    bool primeiraLetraComecaM;

    primeiraLetraNome = 'G';
    nome = "Gabriella";
    valor = 0.4f;
    valorAlto = 1231.45;
    valorAlto2 = 10;
    primeiraLetraComecaM = false;

    Console.WriteLine(primeiraLetraNome);


    if (valorAlto == valorAlto2 || valorAlto2 <= valorAlto)
    {
        Console.WriteLine($"{valorAlto} é maior que {valorAlto2}");
    }
    Console.ReadLine();

    Console.WriteLine("**** Programa de Pagamentos ****");
    Console.WriteLine("Qual o seu nome?");
     nome = Console.ReadLine();
    Console.WriteLine("Qual a sua idade?");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine($"Resultado: ");
    Console.WriteLine($"Seu nome é: {nome}");
    Console.WriteLine($"Sua idade é: {idade}");
    Console.ReadLine();
}