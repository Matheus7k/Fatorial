internal class Program
{
    static int Fatorial(int fatorial)
    {
        if (fatorial == 0 || fatorial == 1)
        {
            return 1;
        }
        else
        {
            return fatorial * Fatorial(fatorial - 1);
        }
    }

    private static void Main(string[] args)
    {
        int fatorial;

        Console.Write("Digite um numero fatorial: ");
        fatorial = int.Parse(Console.ReadLine());

        Console.Write($"O valor de {fatorial}! é: {Fatorial(fatorial)}");
    }
}