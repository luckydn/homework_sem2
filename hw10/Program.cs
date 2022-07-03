Console.WriteLine("Введите трехзначное число, что бы программа определила 2е число");

int number = Convert.ToInt32(Console.ReadLine());
if(number > 99)
    {
        if(number < 1000)
            {
                int result = (number % 100) / 10;
                Console.WriteLine($"{number} -> {result}");
            }
        else
            {
                Console.WriteLine("Число не являлется трехзначным. Попробуйте снова.");
            }
    }
else
    {
        Console.WriteLine("Число не являлется трехзначным. Попробуйте снова.");

    }



