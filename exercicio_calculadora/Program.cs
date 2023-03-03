internal class Program
{
    private static void Main(string[] args)
    {
        //exercicio calculadora simples

        double n1, n2, conta;

        Console.WriteLine("Digite o primeiro numero: ");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        n2 = double.Parse(Console.ReadLine());

        conta = n1 + n2;
        Console.WriteLine("soma: " + conta);

        conta = n1 - n2;
        Console.WriteLine("Subtracao: " + conta);

        conta = n1 * n2;
        Console.WriteLine("multiplicacao: " + conta);

        if (n2 == 0)
        {
            Console.WriteLine("impossivel dividir");
        }
        else
        {
            conta = n1 / n2;
            Console.WriteLine("divisao: " + conta);
        }
    }
}