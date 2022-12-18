// Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, 
// сумма которого, больше суммы элементов расположенных в четырех "углах" 
// двумерного массива.

// Например, задан массив:
// 4 4 7 5
// 4 3 5 3
// 8 1 6 8 -> нет

// 2 4 7 2
// 4 3 5 3
// 2 1 6 2 -> да

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

void IfRowExist(int[,] inputArray)
{
    int sum = 0;
    sum = sum + inputArray[0, 0] + inputArray[0, inputArray.GetLength(1) - 1] +
    inputArray[inputArray.GetLength(0) - 1, 0] + inputArray[inputArray.GetLength(0) - 1, inputArray.GetLength(1) - 1];
    Console.WriteLine($"Сумма элементов 'по углам' = {sum}");

    int count = 0;
    int sumRows = 0;
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            sumRows = (sumRows + inputArray[i, j]);
        }
        if (sumRows > sum)
            count++;
        else
            count *= 1;
        sumRows = 0;
    }
    Console.WriteLine(count > 0 ? "Есть столбец больше суммы 'углов'" : "Нет столбца больше суммы 'углов'");
}
IfRowExist(array);
