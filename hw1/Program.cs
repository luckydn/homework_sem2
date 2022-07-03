// Напишите программу, которая выводит случайное 
//трёхзначное число и 
//удаляет вторую цифру этого числа



int randomNumber = new Random().Next(100, 999);
Console.WriteLine(randomNumber);
int number1 = randomNumber / 100;
int number3 = randomNumber % 10;
int result = number1 * 10 + number3;
Console.WriteLine($"{result}");
