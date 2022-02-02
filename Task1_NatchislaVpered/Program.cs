// Вывести нат.числа от 1 до N

void NatChisla (int i,int max)
{
    if (i<=max)
    {
        Console.WriteLine (i);
        NatChisla (i+1,max);
    }
}
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
NatChisla (i,N);

