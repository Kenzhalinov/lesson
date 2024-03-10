int value = 5;
void Mart(int i)
{

    if (i != 0)
    {
        Console.WriteLine($"{i}");
        i--;
        Mart(i);
    }

}

Mart(value);