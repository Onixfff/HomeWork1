void NatureleNum(int n, int lastN = 1)
{
    if(n == lastN - 1)
    {
        return;
    }
    else
    {
        System.Console.Write(n + " ");
        NatureleNum(--n);
    }
}

NatureleNum(8);