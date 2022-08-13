// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int Lnumber = number.Length;
char FindNumber()
{
    if (Lnumber < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    char Simbole = number[2];
    return Simbole;
}
char result = FindNumber();
Console.WriteLine(result);





