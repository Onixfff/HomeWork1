int Acerman(int n, int m)
{
    if( n == 0)
    {
        return m + 1;
    }
    else if( m == 0)
    {
        return Acerman(n - 1, 1);
    }
    else
    {
        return Acerman(n - 1, Acerman(n, m -1));
    }
}

System.Console.WriteLine(Acerman(3,2));