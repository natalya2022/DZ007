/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] FillArray(int numLine, int numColumns, int minRand, int maxRand)         // Функция создания и заполнения двумерного массива случайными числами  
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = new Random().Next(minRand, maxRand);
        }
    }
    return matrix;
}

void PrintArray2(int[,] matrix)              // Функция печати двумерного массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }

}

double[] AvgCol(int[,] matrix)      // Функция вычисляет среднее арифметическое каждого столбца
{
    double[] avg = new double[matrix.GetLength(1)];     // Массив для хранения результатов
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        avg[j] = (double)sum / matrix.GetLength(0);
    }
    return avg;
}

void PrintArray(double[] myArr)                            // Функция печати одномерного массива    
{
    for (int j = 0; j < myArr.Length; j++)
    {
        System.Console.Write($"{myArr[j]:f}\t");
    }
}

int[,] matrix = FillArray(5, 7, -5, 10);           // Вводим параметры массива
double[] avg = AvgCol(matrix);
PrintArray2(matrix);
PrintArray(avg);

