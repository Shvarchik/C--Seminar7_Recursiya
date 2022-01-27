
// Сумма цифр числа N

int Function (int n) => n<10 ? n : Function(n/10) + n%10;
{
    // можно так: 
    // if (n<10) return n;
    // else return Function(n/10) + n%10;
    // или так:
    // return n<10 ? n : Function(n/10) + n%10;
}
Console.Write ("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр числа {N} равна {Function(N)}");