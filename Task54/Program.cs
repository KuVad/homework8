// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int a = 5;
int b = 6;
int[,] array = new int[a, b];

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for(int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]}   ");
        }
        Console.WriteLine("");
    }
}

FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        int maxPosition = j;

        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > array[i, maxPosition]) maxPosition = k;
        }

        int temporary = array[i, j];
        array[i, j] = array[i, maxPosition];
        array[i, maxPosition] = temporary;
    }
}
Console.WriteLine();
PrintArray(array);