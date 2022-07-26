
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.Clear();

Console.Write("Input quantity of array rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input quantity of array columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min element of array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max element of array: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine();

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(min, max);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Input number: ");
int num = int.Parse(Console.ReadLine());
string Position(int[,] array)
{
    string result = string.Empty;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (num == array[m, n]) result += $"({m}, {n})";
        }
    }
    if (result == string.Empty) result = "This element doesn't exist";
    return result;
}
Console.WriteLine($"{num} -> {Position(array)}");


Console.WriteLine();
Console.ReadKey();