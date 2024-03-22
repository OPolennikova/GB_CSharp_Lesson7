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
Console.WriteLine();


// Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int AckFunction(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckFunction(m - 1, 1);
    }
    else
    {
        return AckFunction(m - 1, AckFunction(m, n - 1));
    }
}

int result = AckFunction(2, 3);
Console.Write(result);
Console.WriteLine();



// Задача 3. Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы

void PrintArrayReversed(int[] array, int index)
{
    if(index < 0)
    {
        return;
    }

    Console.Write(array[index] + " ");
    PrintArrayReversed(array, index - 1);
}


int [] array = {1, 2, 5, 0, 10, 34};
PrintArrayReversed(array, array.Length - 1);
Console.WriteLine();
