int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);
int num4 = int.Parse(Console.ReadLine()!);

int MultiNum(int a, int b)
{
    return a * b;
};


int SumNum(int a, int b)
{
    return a + b;
};

Console.WriteLine(MultiNum(num1, num2) / SumNum(num3, num4));