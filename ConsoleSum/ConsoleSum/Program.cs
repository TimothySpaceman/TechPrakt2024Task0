using static System.Console;

var a = ValidateInt("Enter integer А: ", "Incorrect value! Try again");
var b = ValidateInt("Enter integer B: ", "Incorrect value! Try again");

WriteLine($"\n{a} + {b} = {a + b}");
WriteLine("\nPress any key to exit.");
ReadLine();
return;

int ValidateInt(string message, string errorMessage)
{
    int result;
    bool isOk;
    do
    {
        Write(message);
        isOk = int.TryParse(ReadLine(), out result);
        if (!isOk) WriteLine(errorMessage);
    } while (!isOk);

    return result;
}