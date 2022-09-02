// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillMatrix(array);
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

PrintArray(array);
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

 
for (int i = 0; i < n; i++) //среднее арифметическое
{
  double A = 0;
 
  for (int j = 0; j < m; j++)
  {
    A += (double) array[j, i];
   
  }
  A = Math.Round((double)A/m, 1);
    Console.WriteLine($"Cреднее арифметическое столбца № {i+1} {A}");
}