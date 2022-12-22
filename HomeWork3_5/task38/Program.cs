// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] Array(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(Math.Round(new Random().NextDouble(),2));
    }
        return array;
}

void PrintArray(double[] arr1)
{
    for(int i = 0; i < arr1.Length; i++)
    {
    if(i == 0) Console.Write($"[{arr1[i]}; ");
    if(i == arr1.Length-1) Console.Write($"{arr1[i]}]");
    if(i!=0 && i!=arr1.Length-1) Console.Write($"{arr1[i]}; ");
    }
}

void Diff(double[] inArray)
{
    double max = inArray[0];
    double min = inArray[0];
    // for(int i = 0; i < inArray.Length; i++)
    // {
    //     if (inArray[i] > max) max = inArray[i];
    
    //     if(inArray[i] < min) min = inArray[i];
    // }
    foreach (double el in inArray)
    {
        if(el > max) max = el;
        if(min > el) min = el;
    }

    Console.Write(" -> " + Math.Round((max-min),2));
  }
 
int size = new Random().Next(3,7);
double[] array = Array(size);
PrintArray(array);
Diff(array);
