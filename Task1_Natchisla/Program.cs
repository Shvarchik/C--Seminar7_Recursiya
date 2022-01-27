// Вывести цифры от 1 до N
int NaturalChisla(int n)
{
    //if (n == 1)
    // return n;
    //else
    // return NaturalChisla(n-1) + 1;
    return n==1 ? n : NaturalChisla(n-1) + 1;
}
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= N; i++)
    Console.Write ($"{NaturalChisla(i)} ");


