// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int a = 3;
int[,] array1 = new int[a, a];
int[,] array2 = new int[a, a];

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(0, 10);
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

FillArray(array1);
FillArray(array2);
Console.WriteLine("Матрица А:");
PrintArray(array1);
Console.WriteLine("Матрица В:");
PrintArray(array2);

int[,] array_res = new int[a, a];

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        int summa = 0;
        for (int k = 0; k < a; k++)
        {
            summa = summa + array1[i, k] * array2[k, j];
        }
        array_res[i, j] = summa;
    }
}

Console.WriteLine("Произведение матриц АхВ:");
PrintArray(array_res);