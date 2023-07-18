int[,] array = CreateArray(3, 4);
ShowArray(array);
System.Console.WriteLine();
SortsInDescendingOrder(array);
ShowArray(array);

int[,] CreateArray(int m, int n)
{
    Random random = new Random();
    int minRandom = 1;
    int maxRandom = 10;

    int[,] array = new int[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minRandom, maxRandom);
        }
    }

    return array;
}

void ShowArray(int[,] array)
{
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for(int i = 0; i < rows; i ++)
        {
            for(int j = 0; j < columns; j++)
            {
                if(j < columns -1)
                {
                    System.Console.Write(array[i,j] + ", ");
                }
                else
                {
                    System.Console.Write(array[i,j]);
                }
            }
            System.Console.WriteLine();
        }
}

void SortsInDescendingOrder(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int temp;

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int t = 0; t < columns - 1; t++)
            {
                if(array[i,t] > array[i,t+1])
                {
                    temp = array[i, t];
                    array[i,t] = array[i,t+1];
                    array[i,t+1] = temp;
                }
            }
        }
    }
}