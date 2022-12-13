// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double Exponent(double numA, int numB)
{
    double result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result*numA;
    }
    return result;

}
Console.WriteLine("Введите число");
double a = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень в которую необходимо возвести число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{a} в степени {b} -> {Exponent(a,b)}");

