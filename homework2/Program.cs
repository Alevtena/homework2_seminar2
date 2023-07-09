// Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int CutNumber (int number)
{
int hundres = number / 100;
int units = number % 10;
int result = (number - hundres * 100 - units) / 10;
return result;
}
int randNumber = new Random().Next(100,1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");