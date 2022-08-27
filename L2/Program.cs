/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет. */

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}


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

void FindElem(int[,] matrix, int row, int col)          // Функция выводит элемент по индексам
{
    if (row < matrix.GetLength(0)&& row >= 0 && col < matrix.GetLength(1) && col >= 0)
    {
        System.Console.WriteLine($"Искомый элемент массива равен {matrix[row, col]}");
    }
    else
    {
        System.Console.WriteLine($"Элемент не найден");
    }
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

int[,] matrix = FillArray(5, 3, 0, 10);
int row = Prompt("Введите номер строки ");
int col = Prompt("Введите номер столбца ");
PrintArray2(matrix);
FindElem(matrix, row, col);
