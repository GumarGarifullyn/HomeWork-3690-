// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int n = N;
int NumLenght = 0;
while (n > 0)
{
    n = n / 10;
    NumLenght++;
}
Console.WriteLine(NumLenght);
int degree = NumLenght-1;
int count = 0;
 int sum = 0;
while(degree >= (NumLenght/2))
    {
        Console.Write((int)N/(int)Math.Pow(10, degree) % 10 + "///");
        Console.Write((int)N/(int)Math.Pow(10, count) % 10 + "///");
        if ((int)N/(int)Math.Pow(10, degree) % 10 == (int)N/(int)Math.Pow(10, count) % 10)
        {sum = sum +1;}
        else
        {
            break;
        }
    degree = degree - 1;
    count = count + 1;
Console.WriteLine(sum + "//");
    }       
if(sum >= NumLenght/2)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не палиндромом");
}