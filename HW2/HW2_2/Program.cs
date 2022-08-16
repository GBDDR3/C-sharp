// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число ");
string number = Console.ReadLine();
char FindNumber()
{
    int Lnumber = number.Length;
    char Simbole = number[2];
    if (Lnumber > 3)
    {
        return Simbole;
    }
    else
    {
        throw new Exception("qqq");
    }
}

char result = FindNumber();
Console.WriteLine(result);





