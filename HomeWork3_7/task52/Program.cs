// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray()  // Метод создания рандомного двумерного массива с длиной строк и столбцов от 2 до 10
{
    int m = new Random().Next(2,5);
    Console.WriteLine("m = " + m);
    int n = new Random().Next(2,5);
    Console.WriteLine("n = " + n);

    int[,] NewArr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            NewArr[i, j] = new Random().Next(0,11);
        }
    }
    return NewArr;
}
void PrintArray(int[,] inArray)  // Отображение двумерного массива на консоль
{
        for (int i = 0; i < inArray.GetLength(0); i++)
    {
            for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(j == inArray.GetLength(1)-1) Console.Write($"{inArray[i, j]} ");
            else Console.Write($"{inArray[i, j]}; ");
        }
        Console.WriteLine();
    }
}
void Average(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double sum = 0;
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for(int i = 0; i <  arr.GetLength(0); i++)
        sum = sum + arr[i,j];
        Console.Write(Math.Round(sum/arr.GetLength(0),1) + " ");
    }
    sum = 0;
    }

int[,] arrayRandom = GetArray();
PrintArray(arrayRandom);
Average(arrayRandom);

