using CaCalcClasse;

Contas contas = new Contas(3, 44);

// Cores
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.Clear();

int opcao = 0;

do
{
    // Menu
    Console.WriteLine("Menu" +
        "\n1. Somar" +
        "\n2. Subtrair" +
        "\n3. Multiplicar" +
        "\n4. Dividir" +
        "\n0. Sair");
    Console.WriteLine("Escolha uma opção:");

    opcao = int.Parse(Console.ReadLine()!);
    Console.Clear();

    if (opcao > 0 && opcao < 5)
    {
        string resp;

        do
        {
            // Ler valores
            Console.WriteLine("Informe o primeiro numero: ");
            contas.Num1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o segundo numero: ");
            contas.Num2 = double.Parse(Console.ReadLine()!);

            // Operação
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Resultado: {contas.Somar()}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {contas.Subtrair()}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {contas.Multiplicar()}");
                    break;
                case 4:
                    Console.WriteLine($"Resultado: {contas.Dividir()}");
                    break;
            }

            Console.WriteLine("Deseja continuar nesta operação? (s/n)");
            resp = Console.ReadLine()!.ToLower();

            Console.Clear();

        } while (resp == "s");
    }

} while (opcao != 0);

Console.WriteLine("Adeus!");
