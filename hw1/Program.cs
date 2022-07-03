// Напишите программу, которая выводит случайное 
//трёхзначное число и 
//удаляет вторую цифру этого числа



int randomNumber = new Random().Next(100, 999);
Console.WriteLine(randomNumber);
int number1 = randomNumber / 100;
int number2 = (result % 100) / 10;
int number3 = result % 10;
Console.WriteLine($"{number1}{number3}");
