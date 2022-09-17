Console.WriteLine("Задайте значение M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = int.Parse(Console.ReadLine());

string printR(int a,int b)
{
    if (a == b) return b.ToString();
    else return a +","+ printR(a + 1, b);
}

Console.WriteLine("Результат:"+ printR(m,n));
