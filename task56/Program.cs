int[,] array = CreateArray(4, 4);
ShowArray(array);
int minRows = MinSumRows(array);
System.Console.WriteLine($"Минимальная сумма находиться в строке - {minRows}");

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

int MinSumRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    int index = 0;
    int sum = 0;
    int minSum = int.MaxValue;

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            sum += array[i,j];
        }
        
        if(sum < minSum)
        {
            minSum = sum;
            index = i;
        }

        sum = 0;
    }

    return index + 1;   
}