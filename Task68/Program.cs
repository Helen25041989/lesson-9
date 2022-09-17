Console.WriteLine("Задайте значение M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N:");
int n = int.Parse(Console.ReadLine());

int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if (n != 0 && m == 0)
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}

Console.WriteLine("Результат:"+A(2, 3));