Console.WriteLine("Hello!!!");

Console.WriteLine("Input the first number:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubstract numbers");
Console.WriteLine("[M]ultiply numbers");

string userChoice = Console.ReadLine();

if (CaseInsensitiveEquals(userChoice, "A"))
{
    int calculationResult = AddNumbers(firstNumber, secondNumber);
    PrintResults(firstNumber, "+", secondNumber, calculationResult);
}
else if (CaseInsensitiveEquals(userChoice, "S"))
{
    int calculationResult = SubstractNumbers(firstNumber, secondNumber);
    PrintResults(firstNumber, "-", secondNumber, calculationResult);
}
else if (CaseInsensitiveEquals(userChoice, "M"))
{
    int calculationResult = MultiplyNumbers(firstNumber, secondNumber);
    PrintResults(firstNumber, "*", secondNumber, calculationResult);
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

bool CaseInsensitiveEquals(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

void PrintResults(int firstNumber, string @operator, int secondNumber, int calculationResult)
{
    Console.WriteLine(firstNumber + " " + @operator + " " + secondNumber + " = " + calculationResult);
}

int MultiplyNumbers(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}

int SubstractNumbers(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}

int AddNumbers(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}