Console.WriteLine("Введите число и программа определит третью цифру заданного числа");
int number = Convert.ToInt32(Console.ReadLine());
int threeNumber(int number)
{
    int result = 0;
    if(number < 100)
        {
            Console.WriteLine("У заданного числа нет третьей цифры");
        }
    if(number > 100 && number < 1000) result = number % 10;
    if(number > 1000 && number < 10000) result = (number % 100) / 10;
    if(number > 10000 && number < 100000) result = (number % 1000) / 100;
    if(number > 100000 && number < 1000000) result = (number % 10000) / 1000;
    return result;
}
int result = threeNumber(number);
Console.WriteLine($"{result}");

