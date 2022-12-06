// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
int N = Math.Abs(int.Parse(Console.ReadLine()!));

if (N < 100)
{
    Console.WriteLine("Третьей цифры в вашем числе нет");
}
else
{
    while (N >= 1000)
    {
        N = N / 10;
    }
    int thirdNumber = N % 10;
    Console.WriteLine("Третья цифра числа -> " + thirdNumber);
}