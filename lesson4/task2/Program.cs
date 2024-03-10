int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };
int[] temp = new int[arr.GetLength(1)];

for (int i = 0; i < arr.GetLength(1); i++)
{
    temp[i] = arr[0, i];
}
for (int i = 0; i < arr.GetLength(1); i++)
{
    arr[0,i]= arr[arr.GetLength(0)-1,i];
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine("");
}