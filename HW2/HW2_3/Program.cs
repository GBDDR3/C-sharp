// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите чисо от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

string week()
{
    if (number == 6 ^ number == 7)
    {
        return "Да";
    }
    else
    {
        return "Нет";
    }
}
string result = week();
Console.WriteLine(result);





