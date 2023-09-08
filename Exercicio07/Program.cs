class Program
{
    static void Main(string[] args)
    {
        for (int contador = 1; contador <= 100; contador++)
        {
            Console.WriteLine(contador);
        }

        string[] nomes = new string[6];
        {
            nomes[0] = "Rafael";
            nomes[1] = "Gabriella";
            nomes[2] = "João";
            nomes[3] = "Maria";
            nomes[4] = "Fatima";
            nomes[5] = "Jose";

            int contador = 1;
            for (int cont = 0; cont < 6; cont++)
            {

                Console.WriteLine($"{contador}. {nomes[cont]}");
                contador = contador + 1;
            }
        }
    }
}