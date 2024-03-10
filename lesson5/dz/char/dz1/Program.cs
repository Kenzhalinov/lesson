char[,] array = {
                    {'H','e','l','l','o',','},
                    {'W','o','r','l','d','!'}
                };

string NewSrting(char[,] arr)
{
    string res = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1);j++)
        {
            res = res + arr[i,j];
        }
    }
    return res;
}

Console.WriteLine(NewSrting(array));