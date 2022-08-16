int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());

double FindDistance(int Ax,int Ay,int Bx,int By)
{
    double A = Math.Pow((Ax - Ay), 2);
    double B = Math.Pow((Bx - By), 2);
    double Distanse = Math.Sqrt(A + B);
    return Distanse;
}
double result = FindDistance(Ax, Ay, Bx, By);
Console.WriteLine(result);

// Console.Write("Введите число");
// double number = Convert.ToInt32(Console.ReadLine());

// double SqrtNumbers(double number)
// {
//     for (int i = 1; i < number; i++)
//     {
//         Math.Pow(number,2);
//         return number;
//         //Console.Write(number);
//         //Console.Write(", ");
//         //throw new Exception("Введите другое число");
//     }
// }
//  Console.Write(number);

// int result = FindNumber();

// string FindNumber(int quater)
// {
//     if (quater == 1)
//     {
//         return "x > 0, y > 0";
//     }
//     if (quater == 2)
//     {
//         return "x < 0, y > 0";
//     }
//     if (quater == 3)
//     {
//         return "x < 0, y < 0";
//     }
//     if (quater == 4)
//     {
//         return "x < 0, y < 0";
//     }
//  throw new Exception("Что то пошло не так");
// }