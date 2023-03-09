// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

bool SearchPosition(int[,] array, int row, int col)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i, col] == row)
            return true;
    }
    System.Console.WriteLine("Нет такого числа в массиве");
    return false;
}

int userRow = InputUser("Введите количество строк");
int userColumn = InputUser("Введите количество столбцов");
int[,] matrix = GenerateArray(userRow, userColumn);
PrintArray(matrix);
int searchRow = InputUser("Введите номер позиции строки");
int searchColumn = InputUser("Введите номер позиции столбца");
System.Console.WriteLine($"Элемент c позицией [{searchRow},{searchColumn}] = {SearchPosition(matrix, searchRow, searchColumn)}");
