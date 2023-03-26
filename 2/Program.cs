// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GenereteMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rang = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rang.Next(0, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
int SumLine(int[,] matrix1)
{
    int sum = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j= 0; j < matrix1.GetLength(1) ; j++)
        {
            sum += matrix1[i, j];
        }
        System.Console.WriteLine("Сумма " + (i+1) + " строки равна " + sum);
        sum =0;
    }
    return sum;
}

int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenereteMatrix(m, n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
SumLine(myMatrix);