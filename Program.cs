/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

/* void InputArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] =Math.Round(new Random().NextDouble(), 2) + new Random().Next(0,10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputArray(matrix); */

/* Задача 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
/* void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("введите размер матрицы: ");

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix);

Console.Write("введите номер строки для поиска: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца для поиска: ");
int b = Convert.ToInt32(Console.ReadLine());


if (a <= matrix.GetLength(0) && b <= matrix.GetLength(1))
    Console.Write($"искомое число = {matrix[a, b]}");
else
    Console.Write($"{a}{b} - мимо");
 */

/*  Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;
3. */


/* void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReleaseArray(int[,] matrix)
{
    double avg = 0;
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            avg = sum / matrix.GetLength(0);
        }
        Console.Write($"сумма = {sum} ср.знач = {avg} ");
        sum = 0;
        Console.WriteLine();
    }
    
}

Console.Clear();
Console.Write("введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix);
ReleaseArray(matrix); */

//проверка пуша