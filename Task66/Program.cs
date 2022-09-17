Console.WriteLine("Задайте значение M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = int.Parse(Console.ReadLine());


int sum(int a,int b)
{
    if (a == b) return b;
    else return a + sum(a+1, b);
}

Console.WriteLine("Результат:"+sum(m,n));