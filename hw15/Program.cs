Console.WriteLine("Введите цифру от 1-7, что бы программа определила день недели, и проверила является ли этот день выходным");
int number = Convert.ToInt32(Console.ReadLine());
string[] day = {"Понедельник", "Вторник", "Среда", "Четвер", "Пятница", "Суббота", "Воскресенье" };
int i = number - 1;
if(number < 7)
    {
        if(number == 5)
            {
                string result = day[i];
                Console.WriteLine($"{result} Выходной день");
            }
        else
            {
                string result = day[i];
                Console.WriteLine($"{result} Рабочий день");
            }
    }
else
    {
       Console.WriteLine("Не верное значение, укажите число от 1 до 7");
    }
