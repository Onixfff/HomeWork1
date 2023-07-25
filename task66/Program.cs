void NatureleNum(int n, int m, int sum = 0)
{
    if( n <= m)
    {
        NatureleNum(n + 1, m, sum += n);
    }
    else
    {
        System.Console.WriteLine(sum);
    }
}

NatureleNum(4,8);