Console.WriteLine("Введите число для проверки. кратно ли оно одновременну числу 7 и 23");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0)
    {
        if (number % 23 == 0)
        {
            Console.WriteLine($"Число {number} кратно числам 7 и 23. ");
        }
        else
        {
            Console.WriteLine($"Число {number} не кратно числу 23. ");
        }
    }
else
    {
        Console.WriteLine($"Число {number} не кратно числам 7 и 23. ");
    }
