Console.WriteLine("Введите число и программа определит третью цифру заданного числа");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 100 && number < 1000)
    {
        int result = number % 10;
        Console.WriteLine($"{number} --> {result}");
    }
else if(number > 1000 && number < 10000)
    {
        int result = (number % 100) / 10;
        Console.WriteLine($"{number} --> {result}");
    }
else if(number > 10000 && number < 100000)
    {
        int result = (number % 1000) / 100;
        Console.WriteLine($"{number} --> {result}");
    }
else if(number > 100000 && number < 1000000)
    {
        int result = (number % 10000) / 1000;
        Console.WriteLine($"{number} --> {result}");
    }
else
    {
        Console.WriteLine("У заданного числа нет третьей цифры");
    }
