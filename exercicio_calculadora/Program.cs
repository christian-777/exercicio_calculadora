using System.ComponentModel.Design;


double num1, num2;
int op = 0;

void Menu()
{
    Console.Clear();
    Console.WriteLine("1- Somar\n2- Subtrair\n3- Multiplica\n4- Dividir\n5- Sair");
    Console.WriteLine("Escolha uma 0pção");
    op= int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("soma: "+(num1+num2));
            Console.ReadLine();
            break;

        case 2:
            Console.WriteLine("subtração: " + (num1 - num2));
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine("multiplicação: " + num1 * num2);
            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine("divisao: " + (float) num1 / num2);
            Console.ReadLine();
            break;

        case 5:
            Console.WriteLine("vlw flw");
            Console.ReadLine();
            break;

        default:
            Console.WriteLine("Opção invalida!!");
            Console.ReadLine();
        break;
    }
}

Console.WriteLine("Informe o primeiro numero: ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero: ");
num2 = double.Parse(Console.ReadLine());

while (op != 5)
{
    Menu();


}

