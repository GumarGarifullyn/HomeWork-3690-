// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78

Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int C = int.Parse(Console.ReadLine()!);

// if(A > B && A > C)
// {
//     Console.WriteLine(A);
// }
// if(B > A && B > C)
// {
//     Console.WriteLine(B);
// }

// if(C > A && C > B)
// {
//     Console.WriteLine(C);
// }

int max = A;

 if(B > max)
{
    max = B;
    
}   
 if(C > max)
{
    max = C;
    
} 
        Console.WriteLine(max);