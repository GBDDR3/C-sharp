// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3 

Console.WriteLine("Введите число ");
int nameA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int nameB = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
if(nameA > nameB)
{
max1 = nameA;
}
else
{
max1 = nameB;
}     
Console.Write(max1);

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Input number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number3");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(number1>number2 & number1>number3){
max = number1;
}
if(number2>number3){
max = number2;
}
else{
max = number3;
}
Console.Write(max);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
if(number%2 == 0){
Console.WriteLine("Введенное число является четным");
}
else
{
Console.WriteLine("Введенное число является нечетным");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8.

Console.WriteLine("Input number ");
int number11 = Convert.ToInt32(Console.ReadLine());
int n = 0;
for(int i=n; i<=number11; i+=2){
Console.Write(i);
Console.Write(", ");
}