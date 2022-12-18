// Задача 50. Напишите программу, которая на вход принимает индексы элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс строки массива:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца массива:");
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = FillArray(rows, columns);

PrintArray(array);

int[,] FillArray(int arrayRows, int arrayColumns)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(0, 100);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j] + " ", 3}");
        }
        Console.WriteLine();
    }
}

void PrintNumIndex(int[,] resultArray, int iIndex, int jIndex)
{
    if (iIndex > resultArray.GetLength(0) || jIndex > resultArray.GetLength(1))
        Console.WriteLine("Элемента с данными индексами в массиве нет");
    else
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                if (i == iIndex && j == jIndex)
                    Console.WriteLine(resultArray[i, j]);
            }
        }
}
Console.Write($"Элемент массива с введенными индексми {i},{j}: "); 
PrintNumIndex(array, i, j);