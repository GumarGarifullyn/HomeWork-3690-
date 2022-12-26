// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)


double[,] GetArray()  // Метод создания рандомного двумерного массива с длиной строк и столбцов от 1 до 10
{
    int m = new Random().Next(2,10);
    Console.WriteLine("m = " + m);
    int n = new Random().Next(2,10);
    Console.WriteLine("n = " + n);

    double[,] NewArr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            NewArr[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(-10,10),2);
        }
    }
    return NewArr;
}

void PrintArray(double[,] inArray)  // Отображение двумерного массива на консоль
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
int[] CreateArray(string num)  // Создание массива чисел, вводимую пользователем, через строку, 
                               // с разделителями " " и "/"
{
    string[] array = num.Split(' ', '/');
    int[] arr = new int[array.Length];
        for (int j=0; j < array.Length; j++)
        {
            arr[j] = int.Parse(array[j]);
        }
       
    return arr;
}

void SelectEl(double[,] lookArray, int [] position)
{
   if(position[0] > lookArray.GetLength(0) || position[1] > lookArray.GetLength(1) || position[0] <= 0 ||  position[1] <= 0) 
    {
        Console.WriteLine("Такой позиции не существует");
    }
    else Console.WriteLine("Ваш элемент = " + lookArray[position[0]-1,position[1]-1]);

}

Console.WriteLine("Введите значение позиции элемента через пробел");
string number = Console.ReadLine()!;
double[,] array1 = GetArray();
PrintArray(array1);
CreateArray(number);
SelectEl(array1,CreateArray(number));

