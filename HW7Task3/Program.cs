// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputUser(string message)
{
    System.Console.Write($"{message} = ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (random.Next(1, 10));
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}

void AverageColArray(int[,] array)
{
    System.Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average += array[i, j];
    }
System.Console.WriteLine($"В колонке {j + 1} = {Math.Round(average / array.GetLength(0),2)}");
}
}

int userRow = InputUser("Введите количество строк");
int userColumn = InputUser("Введите количество столбцов");
int[,] matrix = GenerateArray(userRow, userColumn);
PrintArray(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца = ");
AverageColArray(matrix);