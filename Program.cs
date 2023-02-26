Console.Clear();
Console.WriteLine("Task 66");
Console.WriteLine("-------");

int SumNumbers(int m, int n)
{
    if (n == m)
        return m;
    return SumNumbers(m, n - 1) + n;
}

Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от {m} до {n}: {SumNumbers(m, n)}");

Console.ReadLine();

/*--------------------------------------------*/