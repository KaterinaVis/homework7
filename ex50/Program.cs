// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите x");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[5,8];

verifyElement(matrix, x, y);

void verifyElement(int [,] matrix, int x, int y)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j=0; j < matrix.GetLength(1); j++)
      {
      if (matrix[i,j] == matrix [x,y])
        {
        Console.WriteLine(matrix [i,j]);
        }
       else
        {
        Console.WriteLine("Такого элемента в массиве нет");
        }
        }
    }
}



int[,] FillMatrix(int rowsCount, int columsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j=0; j < matrix.GetLength(1); j++)
      {
        matrix[i,j] = rand.Next(leftRange, rightRange+1);
      }
    }
    return matrix;
}
