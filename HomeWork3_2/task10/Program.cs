﻿// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine()!);
if(N>99 && N<1000) 
{
    Console.WriteLine((N%100)/10);
}
else 
{
    Console.WriteLine("Вы ввели не правильное число");
}