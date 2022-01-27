// 73. Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
double Fibi (int n, int n1, int n2)
{
    if (n==1) return n1;
    if (n==2) return n2;
    return Fibi (n-1,n1,n2) + Fibi (n-2,n1,n2); 
}
Console.Write ("Введите первый элемент: ");
int element1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Введите второй элемент: ");
int element2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write ("Сколько чисел показать? ");
int N = int.Parse(Console.ReadLine() ?? "0");
for (int i=1;i<=N;i++)
    Console.WriteLine (Fibi (i,element1,element2));