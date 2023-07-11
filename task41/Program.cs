int count = 0;
string exit = "break";
bool checkParse = false;

while(true)
{
    Console.WriteLine("Введите число\nДля подсчета введите break");
    string userInput = Console.ReadLine();
    if(userInput.ToString() == "break")
    {
        Console.Clear();

        if(checkParse == true)
            System.Console.WriteLine(count);
        else
            System.Console.WriteLine("Error. UserInput");
    }
    else
    {
        int result;
        checkParse = Int32.TryParse(userInput, out result);
        count++;
    }
}