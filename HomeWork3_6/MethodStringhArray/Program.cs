double[] GetArray(string num)  // Создание массива чисел, вводимую пользователем, через строку, 
                               // с разделителями " " и "/"
{
    string[] array = num.Split(' ', '/');
    double[] arr = new double[array.Length];
        for (int j=0; j < array.Length; j++)
        {
            arr[j] = double.Parse(array[j]);
        }
       
    return arr;
}

void PrintArray(double[] arr1) // Отображение массива
{
    for(int i = 0; i < arr1.Length; i++)
    {
    if(i == 0) Console.Write($"[{arr1[i]}; ");
    if(i == arr1.Length-1) Console.Write($"{arr1[i]}]");
    if(i!=0 && i!=arr1.Length-1) Console.Write($"{arr1[i]}; ");
    }
}

Console.WriteLine("Введите числа, через пробел или /");
string n = Console.ReadLine()!;
PrintArray(GetArray(n));
