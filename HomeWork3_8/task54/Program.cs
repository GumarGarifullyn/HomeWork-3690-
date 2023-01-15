// Оформляем всё в методы!
// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] CopySortGetArray(int[,] inArray)  // Метод создания рандомного двумерного массива с длиной строк и столбцов от 2 до 10
{
    int[,] copyArr = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0)-1; i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            int max = copyArr[i,j];
            if (max < inArray[i,j])
            {
                max = copyArr[i+1,j+1];
            }
            else copyArr[i,j] = inArray[i,j];
        }
        
    }
    return copyArr;
}

// void PrintArray2(int[,] inArray2)  // Отображение двумерного массива на консоль
//     {
//        int[] newSingleArr = new int[inArray2.GetLength(0)];
       
//         for (int i = 0; i < inArray2.GetLength(0); i++)
//         {
//             int k = 0;
//             for (int j = 0; j < inArray2.GetLength(1); j++)
//             {
               
//                 newSingleArr[k] = inArray2[i,j];
//                 Console.Write(newSingleArr[k] + " ");
//                 if(k < inArray2.GetLength(0)) k++;
//             }
//             Console.WriteLine();
        
//             Array.Sort(newSingleArr);
//             Array.Reverse(newSingleArr);
//             for(int a =0; a < inArray2.GetLength(0); a++);
//                 for(int b = 0; b < newSingleArr.Length; b++)
//                 {
//                     int a = 0;
//                     newSingleArr[b] = new int inArray3[a,b];
//                 }        
//         }        
        
//     }

int[,] arrayRandom = GetArray();
PrintArray(arrayRandom);
Console.WriteLine();
PrintArray(CopySortGetArray(arrayRandom));


