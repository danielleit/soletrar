class Program
{
    static void Main()
    {

        Console.WriteLine("Seja bem-vindo!\n Esse codigo valida se a palavra inserida possui a existencia da letra 'a'!");
        menu();

    }

    static void menu()
    {
        Console.WriteLine("\nInsira o valor para executar a funcao desejada:\n1 = Executar codigo\n2 = Encerrar programa.\n");
        String entradaMenu = Console.ReadLine();
        try
        {
            int selecaoMenu = int.Parse(entradaMenu);

            if (selecaoMenu == 1)
            {
                validarLetraA();
            }
            else if (selecaoMenu == 2)
            {
                Console.Write("Encerrando programa...");
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.Write("-----------------------------------------------------------------------------------------\n");
                Console.Write("Insira o numero inteiro 1 ou 2!");
                Console.Write("\n-----------------------------------------------------------------------------------------");
                menu();
            }

        }
        catch (Exception e)
        {
            Console.Clear();
            Console.Write("-----------------------------------------------------------------------------------------\n");
            Console.Write("Insira o numero inteiro 1 ou 2, nao aceitamos tipo texto, booleanos ou numeros decimais!");
            Console.Write("\n-----------------------------------------------------------------------------------------");
            menu();
        }

    }

    static void validarLetraA()
    {
        Console.Clear();
        Console.Write("Insira uma palavra a ser lida:");
        String entradaPalavra = Console.ReadLine();
        int sum = 0;

        foreach (char letraChar in entradaPalavra)
        {
            String letraString = letraChar.ToString();
            if (string.Equals(letraString, "a", StringComparison.OrdinalIgnoreCase))
            {
                sum += 1;
            }

        }

        if(sum == 0)
        {
            Console.WriteLine("Nao ha palavras 'a' na palavra que voce inseriu!");
            menu();
        }

        Console.WriteLine($"Há o total de {sum} letras 'a' na palavra que voce inseriu!");
        menu();
    }
}