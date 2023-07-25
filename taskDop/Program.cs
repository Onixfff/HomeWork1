void Dop(int firstNum, int secondNum, int N = 4)
{
    if(N != 0)
    {
        System.Console.Write(firstNum + " ");
        Dop(secondNum, firstNum + secondNum, --N);
    }
}

Dop(6, 10);