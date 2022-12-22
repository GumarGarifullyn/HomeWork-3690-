// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void XY (double k1,double k2,double b1,double b2)
{
    double x = Math.Round((k1 - k2)/(b2-b1),2);
    double y = k1*x+b1;
    if(k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны и не пересекаются");
    if(k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    if(b1 == b2) Console.WriteLine($"({0};{0})");
    else Console.WriteLine($"({x};{y})");
}
Console.WriteLine("Введите значения для K1, K2, B1, B2 для уровнений y = K1*x+B1 и y = K2*x+B2");
    double K1 = double.Parse(Console.ReadLine()!);
    double K2 = double.Parse(Console.ReadLine()!);
    double B1 = double.Parse(Console.ReadLine()!);
    double B2 = double.Parse(Console.ReadLine()!);
XY(K1,K2,B1,B2);