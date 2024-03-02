int[] CreateArray(int up, int down, int size)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(down, up);
    };
    return array;
}


bool Search(int a)
{
    if (a < 2)
    {
        return false;
    };
    for (int i = 2; i < a; i++)
    {
        if (a % i == 0)
        {
            return false;
        };

    };
    return true;
}


int CountNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Search(arr[i]))
        {
            count++;
        };
    };
    return count;
}


int up = int.Parse(Console.ReadLine()!);
int down = int.Parse(Console.ReadLine()!);
int size = int.Parse(Console.ReadLine()!);
int[] res = CreateArray(up, down, size);
Console.WriteLine(string.Join(", ", res));
Console.WriteLine(CountNum(res));