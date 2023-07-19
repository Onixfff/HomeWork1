int[,,] array = CreateArray(2,2,2);
ShowArray(array);

int[,,] CreateArray(int x, int y, int z)
{
    Random random = new Random();
    int minRandom = 10;
    int maxRandom = 100;

    int number;

    int[,,] array = new int[x, y, z];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                number = random.Next(minRandom, maxRandom);
                while(LookingForTheMainElements(array, number) == false)
                {
                    number = random.Next(minRandom, maxRandom);
                }
                array[i,j,k] = number;
            }
        }
    }
    return array;
}

void ShowArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i,j,k]}({i}{j}{k}) ");
            }
        }
    }
}

bool LookingForTheMainElements(int[,,] array, int number)
{
    bool accept = true;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                if(number == array[i,j,k])
                {
                    accept = false;
                    return accept;
                }
            }
        }
    }

    return accept;
}