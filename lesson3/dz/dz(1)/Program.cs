
void Infinity()
{
    while (true)
    {
        string str = Console.ReadLine()!;
        if (str == "q")
        {
            Console.WriteLine("Exit");
            return;
        };

        if (EvenNum(str))
        {
            Console.WriteLine("Exit Even Number");
            return;
        }
    };
}

bool EvenNum(string s)
{
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        count = count + Convert.ToInt32(s[i]);

    };


    if (count%2==0)
    {
        return true;
    }
    else
    {
        return false;
    };
}


Infinity();