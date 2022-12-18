// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int coloumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число масива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива:");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(rows, coloumns, min, max);

double[,] FillArray(int rowsArr, int coloumnsArr, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] resultArr = new double[rowsArr, coloumnsArr];
    for (int i = 0; i < rowsArr; i++)
    {
        for (int j = 0; j < coloumnsArr; j++)
            resultArr[i, j] = rnd.Next(minValue, maxValue) + rnd.NextDouble();
    }
    return resultArr;
}

void PrintArray(double[,] inputArr)
{
    for (int i = 0; i < inputArr.GetLength(0); i++)
    {
        for (int j = 0; j < inputArr.GetLength(1); j++)
        {
            Console.Write("{0:F1}", inputArr[i, j]);
            
        }
        Console.WriteLine();
    }
}
PrintArray(array);