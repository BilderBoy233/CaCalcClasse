// See https://aka.ms/new-console-template for more information

using CaCalcClasse;
using System.Threading.Channels;

Contas contas = new Contas(3, 44);

Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;

int opcao = 0;
string resp = "";
do
{
    //Menu
    Console.Clear();
    Console.WriteLine("Menu" +
        "\n1. Somar" +
        "\n2. Subtrair" +
        "\n3. Multiplicar" +
        "\n4. Dividir" +
        "\n0. Sair");
    Console.WriteLine("Escolha uma opção:");
    opcao = int.Parse(Console.ReadLine()!);

        if (opcao > 0 && opcao < 5)
        {
        //Ler os valores
        Console.WriteLine("Informe o primeiro numero: ");
        contas.Num1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe o segundo numero: ");
        contas.Num2 = double.Parse(Console.ReadLine()!);
        }

    //Fazer as ops
    switch (opcao)
    {
        case 1://Somar
            Console.WriteLine(contas.Somar());
            break;
        case 2://Subtrair
            Console.WriteLine(contas.Subtrair());
            break;
        case 3://Multiplicar
            Console.WriteLine(contas.Multiplicacao());
            break;
        case 4://Dividir
            Console.WriteLine(contas.Divisao());
            break;
        case 0:
            Console.WriteLine("Adeus!");    
            break;
        default:
            break;
    }

    if (opcao > 0 && opcao < 5)
    {
        Console.WriteLine("Deseja continuar? (s/n)");
        resp = Console.ReadLine()!.ToLower();
        if (resp == "n")
        {
            Console.WriteLine("Adeus!");
            break;
        }
    }
    
}

while (opcao != 0 );
    
