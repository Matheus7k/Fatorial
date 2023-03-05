int fatorial, fatorialTotal = 1;

int Fatorial()
{
    if (fatorial == 0 || fatorial == 1)
    {
        return 1;
    }
    for (int i = 2; i <= fatorial; i++)
    {
        fatorialTotal *= i;
    }

    return fatorialTotal;
}

Console.Write("Digite um numero fatorial: ");
fatorial = int.Parse(Console.ReadLine());

Console.Write(Fatorial());
