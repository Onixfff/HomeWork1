int[,] array = CreateArray(4);
ShowArray(array);

int[,] CreateArray(int length)
{
    int[,] array = new int[length, length];

    int x = 0;
    int y = 0;
    int d = 0;

    int maxX = length - 1;
    int minX = 1;
    int maxY = length - 1;
    int minY = 0;

    for (int k = 1; k < length * length + 1; k++)
    {
        array[x, y] =  k;
        switch (d)
        {
            case 0:
                if (y < maxY)
                {
                    y++;
                }
                else
                {
                    d = 1;
                    maxY--;
                    k--;
                }
            break;
            case 1:
                if (x < maxX)
                {
                    x++;
                }
                else
                {
                    d = 2;
                    maxX--;
                    k--;
                }
            break;
            case 2:
                if (y > minY)
                {
                    y--;
                }
                else
                {
                    d = 3;
                    minY++;
                    k--;
                }
            break;
            case 3:
                if (x > minX)
                {
                    x--;
                }
                else if(k == length * length)
                {
                    break;
                }
                else
                {
                    d = 0;
                    minX++;
                    k--;
                }
                break;

        }
    }

    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10 )
                System.Console.Write(array[i, j] + "  ");
            else
                Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}