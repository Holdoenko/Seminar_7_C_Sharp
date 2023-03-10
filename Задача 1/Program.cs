
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] num = new double [rows,columns];
FillArrayRandomNum(num);
PrintArray(num);

void FillArrayRandomNum(double[,] array)
{
 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
    }

void PrintArray(double[,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        Console.WriteLine(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
}