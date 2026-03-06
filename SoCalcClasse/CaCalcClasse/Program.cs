// See https://aka.ms/new-console-template for more information

using CaCalcClasse;

Contas contas = new Contas(3, 44);

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Yellow;

int opcao = "0";
do
{
    Console.Clear();
    Console.WriteLine("Menu" +
        "\n1. Somnar" +
        "\n2. Subtrair" +
        "\n3. Multiplicar" +
        "\n4. Dividir" +
        "\n0. Sair");
    Console.WriteLine("Escolha uma opção:");
    opcao = int.Parse(Console.ReadLine()!);

    //Ler os valores
    Console.WriteLine("Informe o primeiro numero: ");
    contas.Num1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Informe o segundo numero: ");
    contas.Num2 = double.Parse(Console.ReadLine()!);

    //Fazer as ops
    switch (opcao)
    {
        case 1://Somar
            Console.WriteLine(contas.Somar());
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 0:
            Console.WriteLine("Adeus!");
            break;
        default:

            break;
    }

    //Console.WriteLine("Deseja continuar? (s/n)");
    //resp = Console.ReadLine()!.ToLower();


    while (resp == "s" || resp == "sim") ;

