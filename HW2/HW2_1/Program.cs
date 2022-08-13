// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int FindNumber(int number)
{
number = number %100;
number = number / 10;
return number;
}
int result = FindNumber(number);
Console.WriteLine(result);