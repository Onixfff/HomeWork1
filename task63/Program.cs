void NatureleNum(int Number, int count = 1)
{
    if(Number < count)
    {
        return;
    }
    else
    {
        System.Console.Write(count + " ");
        NatureleNum(Number, count + 1);
    }
}

NatureleNum(5);