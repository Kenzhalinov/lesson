int[] array = new int[5] { 1, 2, 3, 4, 546 };

void ReverseNumber(int[] arr)
{
    int len = arr.Length;
    if (len > 0)
    {
        Console.Write($"{arr[len - 1]} ");
        int[] newArr = new int[len - 1];
        Array.Copy(arr, 0, newArr, 0, len - 1);
        ReverseNumber(newArr);
    }
}

ReverseNumber(array);