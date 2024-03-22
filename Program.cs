// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintDigits(int M, int N)
{
    if(N < M)
    {
        return;
    }
    PrintDigits(M, N - 1);
    Console.Write(N);
    Console.Write(" ");
}

PrintDigits(1, 5);
