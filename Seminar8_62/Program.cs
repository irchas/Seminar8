// Задача 62: Заполните спирально массив n на n.
Console.Write("Введите размер массива: ");
int n=int.Parse(Console.ReadLine());
int m = n;

int[,] array = GetArray(n, n, 1, 100);
PrintArray(array);
System.Console.WriteLine();

int [,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] array = new int[n, m];
    int i = 0;
    int j = 0;
    int s = 1;
    while (s <= n*m)
    {
        array[i, j] = s;
        s++;
        if (i <= j + 1 && i + j < m - 1)
        j++;
        else if (i < j && i + j >= n - 1)
        i++;
        else if (i >= j && i + j > m - 1)
        j--;
        else
        i--;
    }
   return array;
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.Write($" {array[i,j]} ");
    }
    Console.WriteLine();
  }
}