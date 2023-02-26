Console.Clear();
Console.WriteLine("Task 66");
Console.WriteLine("-------");

int SumNumbers(int a, int b)
{
    if (a == b)
        return b;
    return SumNumbers(a, b - 1) + b;
}

Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от {a} до {b}: {SumNumbers(a, b)}");

Console.ReadLine();

/*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task 68");
Console.WriteLine("-------");

int FuncAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return FuncAkkerman(n-1,1);
    else return FuncAkkerman(n-1,FuncAkkerman(n,m-1));
}

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана ({n},{m}): {FuncAkkerman(m, n)}");

Console.ReadLine();

/*--------------------------------------------*/