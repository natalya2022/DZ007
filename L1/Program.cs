/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


double[,] FillArray(int numLine, int numColumns, int minRand, int maxRand)         // Функция создания и заполнения двумерного массива случайными числами  
{
    double[,] matrix = new double[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = new Random().NextDouble() * (maxRand - minRand) + minRand;      
        }
    }
    return matrix;
}


void PrintArray(double[,] matrix)              // Функция печати двумерного массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i,j]:f}\t");
        }
        Console.WriteLine();
    }
}

 
double[,] matrix = FillArray(3, 4, 0, 10); 
PrintArray(matrix);

