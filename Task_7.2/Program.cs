
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

void GetArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(min, max);
        }
    }
}
void ShowArray(int[,] array)
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

GetArray(array);
ShowArray(array);
Console.WriteLine();

Console.Write("Input number: ");
int findNumber = int.Parse(Console.ReadLine());
string Element(int[,] array)
{
    string find = string.Empty;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (findNumber == array[m, n]) find += $"({m}, {n})";
        }
    }
    if (find == string.Empty) find = "This element doesn't exist";
    return find;
}
Console.WriteLine($"{findNumber} -> {Element(array)}");


Console.WriteLine();
Console.ReadKey();
Console.Clear();
