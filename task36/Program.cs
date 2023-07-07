int[] array = CreateArray();
int sum = SumOfOddIndexElement(array);
ShowArray(array);
System.Console.WriteLine("\nСумма нечетных элементов - " + sum);

int[] CreateArray()
{
    Random random = new Random();
    int maxArraySize = 11;
    int minArraySize = 5;
    int maxArrayNumber = 10;
    int minArrayNumber = 0;

    int[] array = new int[random.Next(minArraySize, maxArraySize)];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minArrayNumber, maxArrayNumber);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int SumOfOddIndexElement(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }

    return sum;
}
