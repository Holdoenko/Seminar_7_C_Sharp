/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
 значение этого элемента или же указание, что такого элемента нет.
 Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 17 -> такого числа в массиве нет*/

Console.Clear();

Console.WriteLine("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[5, 5];
FillArray(num);
PrintArray(num);

if (rows < num.GetLength(0) && colums < num.GetLength(1))
    Console.WriteLine(num[rows, colums]);
else
    Console.Write($"Числа с такими значениями в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}