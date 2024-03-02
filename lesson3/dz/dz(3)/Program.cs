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

int[] ReverseArray(int[] arr){
    for(int i = 0, j = arr.Length-1 ; i < j; i++, j--){
        int temp = arr[i];
        arr[i]=arr[j];
        arr[j]=temp;
    };
    return arr;
}


int up = int.Parse(Console.ReadLine()!);
int down = int.Parse(Console.ReadLine()!);
int size = int.Parse(Console.ReadLine()!);
int[] arr = CreateArray(up, down, size);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(string.Join(", ",ReverseArray(arr)));
