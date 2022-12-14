// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] Array(int len)
{
    int length = len;
    int[] array = new int[length];

    for(int i = 0; i < length-1; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
        
        if(i == 0) Console.Write($"[{array[i]}, ");
        if(i == length-2) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
        return array;
}

Console.WriteLine("Введите длину массива");
int n = int.Parse(Console.ReadLine()!);
Array(n);