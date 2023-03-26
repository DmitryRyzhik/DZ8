// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void LoweringMartix(int[,] myMatrix)
{
    for (int r = 0; r < myMatrix.GetLength(1); r++)
    {
        for (int i = 0; i < myMatrix.GetLength(1); i++)
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
                if (myMatrix[r, i] > myMatrix[r, j])
                {
                    int t = myMatrix[r, j];
                    myMatrix[r, j] = myMatrix[r, i];
                    myMatrix[r, i] = t;
                }
            }
        }
    }
}


int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenereteMatrix(m, n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
LoweringMartix(myMatrix);
PrintMatrix(myMatrix);