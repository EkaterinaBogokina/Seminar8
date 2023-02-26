//Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива


int matrixRows = userNum("Rows");
int matrixColumns = userNum("Columns");
int matrixMinValue = userNum("Min Value");
int matrixMaxValue = userNum("Max Value");
int [,] matrix = Matrix (matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
PrintMatrix(matrix);
Sorting(matrix);
Console.WriteLine();
PrintMatrix(matrix);


       

int userNum(string userNumber)  
{
    Console.Write($"Enter number {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] Matrix(int rows, int columns, int min, int max)  
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10)
                System.Console.Write("0" + matrix[i, j] + " ");
            else
                System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void Sorting (int [,] matrix)  
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i,k] < matrix [i,k+1])
                {
                    int temp = matrix [i,k+1];
                    matrix [i,k+1] = matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
            
        }
    }
}

//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int matrixRows = userNum("Rows");
int matrixColumns = userNum("Columns");
int matrixMinValue = userNum("Min Value");
int matrixMaxValue = userNum("MaxValue");

int[,] matrix = Matrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
PrintMatrix(matrix);
Console.WriteLine($"Minimal sum row= {MinSum(matrix)}");

       

int userNum(string userNumber)  
{
    Console.Write($"Enter number {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] Matrix(int rows, int columns, int min, int max)  
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10)
                System.Console.Write("0" + matrix[i, j] + " ");
            else
                System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int MinSum(int[,] matrix)  
{
    int row = 0;
    int? min = null;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (min == null) min = sum;
        else if (sum < min)
        {
            min = sum;
            row = i;
        }
        System.Console.WriteLine($"Sum {i} = {sum}");
    }
    return row;
}

//Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("First matrix:");
int matrixRows = userNum("Rows");
int matrixColumns = userNum("Columns");
int matrixMinValue = userNum("Min Value");
int matrixMaxValue = userNum("Max Value");
int[,] firstMatrix = Matrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
Console.WriteLine("Second matrix:");
matrixRows = userNum("Rows");
matrixColumns = userNum("Columns");
matrixMinValue = userNum("Min Value");
matrixMaxValue = userNum("Max Value");
int[,] secondMatrix = Matrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
//if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) Console.WriteLine("Эти матрицы умножить нельзя!");
//else 
PrintMatrix(MatrixProd(firstMatrix, secondMatrix));



int userNum(string userNumber)  
{
    Console.Write($"Enter number {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] Matrix(int rows, int columns, int min, int max)  
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10)
                System.Console.Write("0" + matrix[i, j] + " ");
            else
                System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


int[,] MatrixProd(int[,] matrix1, int[,] matrix2)  
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int l = 0; l < matrix2.GetLength(0); l++)
            {
                resultMatrix[i, j] += matrix1[i, l] * matrix2[l, j];
            }
        }
    }
    return resultMatrix;
}


