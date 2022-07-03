// Напишите программу, которая выводит случайное 
//трёхзначное число и 
//удаляет вторую цифру этого числа



int randomNumber = new Random().Next(100, 999);
int result = randomNumber;
int number1 = result / 100;
int number2 = (result % 100) / 10;
int number3 = result % 10;
Console.WriteLine($"Случайное число {result} --> {number1}{number3}");
