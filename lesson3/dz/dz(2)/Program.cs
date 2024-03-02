int[] CreateArray(int up, int down, int size)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(down, up);
    };
    return arr;

}


int EvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    };
    return count;
}


int up = int.Parse(Console.ReadLine()!);
int down = int.Parse(Console.ReadLine()!);
int size = int.Parse(Console.ReadLine()!);


if (up < 1000 && down > 99)
{
    int[] array = CreateArray(up, down, size);
    Console.WriteLine(string.Join(", ", array));
    Console.WriteLine(EvenNum(array));
}
else
{
    Console.WriteLine("Your number outside!");
    return;
};





