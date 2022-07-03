Console.WriteLine("Введите два числа для проверки, является ли второе число кратным первому.");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());


if(numberA % numberB == 0)
{
    Console.WriteLine($"Число кратно и делится без остатка");
}
else
{
    int result1 = numberA % numberB;
    Console.WriteLine($"число {numberA} не кратно числу {numberB}, остаток {result1}");
}
