using System.ComponentModel.Design;


double num1, num2;
int op = 0;

int Menu()
{
    Console.Clear();
    Console.WriteLine("1- Somar\n2- Subtrair\n3- Multiplica\n4- Dividir\n5- Sair");
    Console.WriteLine("Escolha uma 0pção");
    return int.Parse(Console.ReadLine());
}

void escolha() { 
    switch (op)
    {
        case 1:
            Console.WriteLine("soma: "+soma());
            Console.ReadLine();
            break;

        case 2:
            Console.WriteLine("subtração: " + subtracao());
            Console.ReadLine();
            break;

        case 3:
            Console.WriteLine("multiplicação: " + multiplicacao());
            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine("divisao: " + divisao());
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

double soma()
{
    double soma;
    soma = num1 + num2;
    return soma;
}

double subtracao()
{
    double sub;
    sub = num1 - num2;
    return sub;
}

double divisao()
{
    double div;
    div = num1 + num2;
    return div;
}

double multiplicacao()
{
    double mult;
    mult = num1 + num2;
    return mult;
}

Console.WriteLine("Informe o primeiro numero: ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero: ");
num2 = double.Parse(Console.ReadLine());

while (op != 5)
{
    op=Menu();
    escolha();
}

