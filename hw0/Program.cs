int GetRandomNumber(int minBorder, int maxBorder)
{
    int result = new Random().Next(minBorder,maxBorder+1);
    return result;
}

int getMaxDigit(int number)
{
    int result = 0;
    number = Math.Abs(number);
    if(number > 10 && number < 100)
    {
        int digitOne = number / 10;
        int digitTwo = number % 10;
        result = digitOne;
        if(result < digitTwo)
        {
            result = digitTwo;
        }
    }
    else
    {
        Console.WriteLine($"Число {number} не в границе [10, 99]");
    }
    return result;
}
int randomNumber = GetRandomNumber(10,99);
int maxDigit = getMaxDigit(randomNumber);
Console.WriteLine($"найбольшая цифра числа {randomNumber} это {maxDigit}");
