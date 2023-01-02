// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк  1 массива: ");
int rows1=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива = количество строк 2 массива: ");
int columns1=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива: ");
int columns2=int.Parse(Console.ReadLine());

int[,] array1 = GetArray1(rows1, columns1, -10, 10);
PrintArray1(array1);
System.Console.WriteLine();

int[,] array2 = GetArray2(columns1, columns2, -10, 10);
PrintArray2(array2);
System.Console.WriteLine();

int[,] array3 = MultiplyArray(rows1, columns1, columns2);
PrintArray2(array3);
System.Console.WriteLine();

int [,] GetArray1(int rows1, int columns1, int minValue, int maxValue)
{
    int[,] array1 = new int[rows1, columns1];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            array1[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array1;
}

void PrintArray1(int[,] array1)
{
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            Console.Write($"{array1[i,j]} ");
        }
        Console.WriteLine();
    }
}
int [,] GetArray2(int columns1, int columns2, int minValue, int maxValue)
{
    int[,] array2 = new int[columns1, columns2];
    for (int j = 0; j < columns1; j++)
    {
        for (int k = 0; k < columns2; k++)
        {
            array2[j, k ] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2;
}

void PrintArray2(int[,] array2)
{
    for (int j = 0; j < columns1; j++)
    {
        for (int k = 0; k < columns2; k++)
        {
            Console.Write($"{array2[j,k]} ");
        }
        Console.WriteLine();
    }
}

int [,] MultiplyArray(int row1, int columns1, int columns2)
{
    int[,] array3 = new int[rows1, columns2];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            for (int k = 0; k < columns2; k++)
        {
            array3[i, k ] += array1[i, j]*array2[j, k];
        }
        }
    }
    return array3;
}
void PrintArray3(int[,] array3)
{
    for (int i = 0; i < rows1; i++)
    {
        for (int k = 0; k < columns2; k++)
        {
            Console.Write($"{array3[i,k]} ");
        }
        Console.WriteLine();
    }
}