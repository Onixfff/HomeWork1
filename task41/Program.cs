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
        
        count = 0;
    }
    else
    {
        int number;
        checkParse = Int32.TryParse(userInput, out number);
        if(number > 0)
            count++;
    }
}