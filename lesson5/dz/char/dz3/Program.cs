string str = Console.ReadLine();

bool CheckWord(string a)
{
    for (int i = 0,  j = a.Length-1; i < j; i++, j--){
        if (a[j] != a[i]){
            return false;
        }
    }
    return true;
}

if (CheckWord(str))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
};