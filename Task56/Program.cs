// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int a = 5;
int[,] array = new int[a, a];

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

int summa = 0;
int row = 1;
int minSumma = 10000000;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summa += array[i, j];           
    }
    Console.WriteLine($"Сумма строки {i + 1}: {summa} ");
    if (summa < minSumma) 
    {
        minSumma = summa;
        row = i + 1;
    }
    summa = 0;
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row} строка");