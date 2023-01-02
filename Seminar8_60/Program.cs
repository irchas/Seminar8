// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.Write("Введите размер 1 массива: ");
int n1=int.Parse(Console.ReadLine());
Console.Write("Введите размер 2 массива: ");
int n2=int.Parse(Console.ReadLine());
Console.Write("Введите размер 3 массива: ");
int n3=int.Parse(Console.ReadLine());

int[,,] array = GetArray(n1, n2, n3, 10, 100);
PrintArray(array);
System.Console.WriteLine();

int [,,] GetArray(int n1, int n2, int n3, int minValue, int maxValue)
{
    int[,,] array = new int[n1, n2, n3];
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            for (int k = 0; k < n3; k++)
            {
            array[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            for (int k = 0; k < n3; k++)
            {
            Console.Write($"Элемент {i}, {j}, {k} - ");
            Console.Write($"{array[i, j, k]}");
            Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}