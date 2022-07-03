Console.WriteLine("Введите число и программа определит третью цифру заданного числа");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 100)
    {
        int result = number % 10;
        Console.WriteLine($"{number} --> {result}");
    }
else
    {
        Console.WriteLine("У заданного числа нет третьей цифры");
    }