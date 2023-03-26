// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] ReprMatrix(int[,] matr1, int[,] matr2)
{
    int[,] reprMatrix = new int[matr1.GetLength(1), matr1.GetLength(0)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            reprMatrix[i, j] += matr1[i, j] * matr2[i, j];
        }
    }
    return reprMatrix;
}

int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenereteMatrix(m, n);
PrintMatrix(myMatrix);
System.Console.WriteLine();

int k = m;
int l = n;
var myMatrix1 = GenereteMatrix(k, l);
PrintMatrix(myMatrix1);
System.Console.WriteLine();
var reprMatrix = ReprMatrix(myMatrix, myMatrix1);
PrintMatrix(reprMatrix);

