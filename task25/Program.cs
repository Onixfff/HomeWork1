int Retue(int num, int pow)
{
    int sum = num;
    for (int i = 1; i < pow; i++)
    {
        sum *= num;
    }
    return sum;
}

System.Console.WriteLine(Retue(3,5));
