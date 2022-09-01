// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[3, 4];

FillMatrix(matrix);
PrintArray(matrix);
Console.WriteLine("");
verifyElement(matrix, m, n);

void FillMatrix(int[,] matr) // метод для рандомного заполнения
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] matr) // метод для печати
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void verifyElement(int[,] matr, int row, int col) //метод для сравниания индексов
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == row && j == col)
            {
                Console.WriteLine($"Искомый элемент: {matrix[i, j]}");
            }
        }
    }
     if (row > matr.GetLength(0) || col > matr.GetLength(1))
            {
                Console.WriteLine("Такого элемента нет");
            }
}

