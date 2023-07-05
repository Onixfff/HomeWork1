int[] array = new int[8];

PrintArray(array);
array = AssignsRandomValues(array);
PrintArray(array);

int[] AssignsRandomValues(int[] array)
{
    int[] randomArray = array;
    Random rnd = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        randomArray[i] = rnd.Next(0,100);
    }

    return randomArray;
}

void PrintArray(int[] array)
{
    System.Console.Write("\n[");

    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}");
        if(i < array.Length - 1)
            System.Console.Write(", ");
    }

    System.Console.Write("]");
}

