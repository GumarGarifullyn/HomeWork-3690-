// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] Array(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue+1);
    }
        return array;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
    if(i == 0) Console.Write($"[{arr[i]}, ");
    if(i == arr.Length-1) Console.Write($"{arr[i]}]");
   if(i!=0 && i!=arr.Length-1) Console.Write($"{arr[i]}, ");
    }
}

void Even(int[] number)
{
        int sum = 0;
        
    for(int num = 0; num < number.Length; num++)
        {
       while (num < number.Length)
       {
        if(number[num]%2 == 0) sum = sum + 1;
        num++;
       }
        }
    Console.Write($"-> {sum}");
}

int[] array = Array(7,100,999);
PrintArray(array);
Even(array);



