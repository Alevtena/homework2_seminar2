// Task 1. Вариант 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int CutNumber (int number)
{
int hundres = number / 100;
int units = number % 10;
int result = (number - hundres * 100 - units) / 10;
return result;
}
Console.Write ("Input a three-digit number");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number<100 || Number > 1000) 
{
    Console.Write ("You are inputed not tree-digit number  ");
}
else 
{int digit = CutNumber(Number);
Console.WriteLine($"Second digit  of {Number} is {digit}");
}
*/

//  Task 1. Вариант 2. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber (int number)
{
int digit = number / 10 % 10;
return digit;
}

int Number = new Random().Next (100,1000);
Console.WriteLine  ($"Зададим случайное трехзначное число  {Number}");
int digit = CutNumber(Number);
Console.WriteLine($"Second digit  of {Number} is {digit}");
*/

// Task 2. Напишите программу, которая выводит третью цифру заданного числа.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
int ThirdDigit (int number)
{
  int result = -1;
  if (number >= 100)
  {
    while (number > 999) number = number / 10;
    result = number % 10;
  }
  return result;
}

int randomNumber = new Random().Next();
Console.WriteLine("Случайное число" + randomNumber);
int digit = ThirdDigit(randomNumber);
if (digit == -1) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"Third digit of {randomNumber} is {digit}");
*/

// Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool WeekNumber (int number)
{
if  (number == 6 || number == 7) return true;
else return false;
}
Console.Write ("Input any numbers from 1 to 7 ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number < 1 || Number > 7) Console.Write ("You are inputed not number from 1 to 7 ");

else 
if (WeekNumber(Number) == true) Console.WriteLine($"день недели под номером {Number}  - выходной");
else Console.WriteLine($"день недели под номером {Number}  - не выходной");