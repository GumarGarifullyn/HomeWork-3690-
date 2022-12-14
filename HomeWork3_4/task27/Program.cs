// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number)
{
    int count = 1;
    int n = number;

    while(n > 0)
    {
        //Console.WriteLine($"{n} -> {n/10} -> {count}");
        n = n/10;
        count++;
    }
    int sum = 0;
    while(count > 1)
    {
        sum = sum + number%10;
        number = number/10;
        count--;
    }
    return sum;
}
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(num));