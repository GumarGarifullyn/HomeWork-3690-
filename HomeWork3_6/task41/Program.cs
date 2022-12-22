// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int PositivCounter (string num)
{
    string[] array = num.Split(' ',',');
    int count = 0;
    int i = 0;
    for(; i < array.Length-1; i++)
    {
        Console.Write(array[i]+";");
        if (int.Parse(array[i]) > 0 )  count = count + 1;
    }
    for(;i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (int.Parse(array[i]) > 0 ) count = count + 1;
    }
    return count;
}


Console.WriteLine("Введите цифры через запятую или пробел");
string numbers = Console.ReadLine()!;
Console.Write(" -> " + PositivCounter(numbers));