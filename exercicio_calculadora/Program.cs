

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
            if(num2 != 0)
            {
                Console.WriteLine("divisao: " + divisao());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("impossivel dividir ");
                Console.ReadLine();
            }
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
    return num1 + num2;
}

double subtracao()
{
    return num1 - num2;
}

double divisao()
{
    return num1 / num2;
    
}

double multiplicacao()
{
    return num1 * num2;

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

