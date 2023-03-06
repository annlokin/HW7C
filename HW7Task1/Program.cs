// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] GenerateArray(int row, int col) 
{ 
    double [,] array = new double [row, col];
    Random random = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = Math.Round(random.Next(-10, 10)*0.1,1); 
        } 
    } 
    return array; 
} 

void PrintArray(double [,] array) 
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


double [,] matrix = GenerateArray(3, 4); 
PrintArray(matrix); 

