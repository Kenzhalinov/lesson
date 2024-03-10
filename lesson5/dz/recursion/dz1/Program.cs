int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);


void CounterNum(int m, int n)
{
    if (n >= m)
    {
        Console.Write($"{m}");
        if (n != m)
        {
            Console.Write($", ");
        }
        m++;
        CounterNum(m, n);
    }
}
CounterNum(num1, num2);