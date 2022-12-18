// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(rows, columns, min, max);

PrintArray(array);
Console.WriteLine();

int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
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
            Console.Write($"{inputArray[i, j] + " ",3}");
        }
        Console.WriteLine();
    }
}

double ArithmeticMeanRows(int[,] inputArray)
{
    double sum = 0;
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            sum = (sum + inputArray[i, j]);
        }
        Console.WriteLine($"Среднее арифметическое {j+1} столбца = {Math.Round(sum/inputArray.GetLength(0),1,MidpointRounding.ToEven)}");
        sum = 0;
    }
    return sum;
}
ArithmeticMeanRows(array);