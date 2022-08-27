/*
Найдите максимальное значение в матрице по каждой строке, ссумируйте их. Затем найдети минимальное значение по каждой колонке,
тоже ссумируйте их. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
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

int SumMaxRow(int[,] matrix)      // Функция суммирует максимальные значения из каждой строки
{
    int sumMax = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (max < matrix[i, j])
            {
                max = matrix[i, j];
            }
        }
        sumMax += max;
    }
    return sumMax;
}

int SumMinCol(int[,] matrix)      // Функция суммирует минимальные значения из каждого столбца
{
    int sumMin = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int min = matrix[0, j];
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
            }
        }
        sumMin += min;
    }
    return sumMin;
}

int[,] matrix = FillArray(3, 2, -10, 10);           // Вводим параметры массива
int sumMax = SumMaxRow(matrix);
int sumMin = SumMinCol(matrix);
PrintArray2(matrix);
System.Console.WriteLine($"Сумма max значений строк = {sumMax}, сумма min значений столбцов = {sumMin}, разность этих значений {sumMax - sumMin}");

