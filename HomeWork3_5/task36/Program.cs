// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] Array(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue+1);
    }
        return array;
}

void PrintArray(int[] arr1)
{
    for(int i = 0; i < arr1.Length; i++)
    {
    if(i == 0) Console.Write($"[{arr1[i]}, ");
    if(i == arr1.Length-1) Console.Write($"{arr1[i]}]");
   if(i!=0 && i!=arr1.Length-1) Console.Write($"{arr1[i]}, ");
    }
}

int Odd(int [] arr2)
{
    int[] array = new int[arr2.Length];
    int sum = 0;
    for(int i = 0; i < arr2.Length; i++)
    {
        if(i % 2 !=0) 
        {
            sum = arr2[i] + sum;
        }
    }
    return sum;
}

int size = new Random().Next(0,21);
int minValue = new Random().Next(-50,0);
int maxValue = new Random().Next(0,51);
int[] array = Array(size,minValue,maxValue);
PrintArray(array);
Console.Write($" - > {Odd(array)}");