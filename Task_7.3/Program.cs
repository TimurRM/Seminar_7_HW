// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

int[,] GetArray(int m, int n)
{
    int[,] newArray = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = new Random().Next(min, max);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]}     ");
        }
        Console.WriteLine();
    }
}

int [,] myArray = GetArray(m, n);
ShowArray(myArray);
Console.WriteLine("--------------------------");


for (int j = 0; j < myArray.GetLength(1); j++)
{
double sum = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        sum = sum + myArray[i,j];
    }
    Console.Write($"{sum/m:f2}  ");
}   Console.WriteLine();

Console.ReadKey();
Console.Clear();
