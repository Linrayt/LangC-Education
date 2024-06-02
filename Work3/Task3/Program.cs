﻿int[,] Creatematrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

int[,] matrix Creatematrix(3, 4); 

foreach (int e in matrix)
{
    if(isintresting(e) true)
    {
        Console.WriteLine(e);
    }
}

bool isintresting(int value)
{
    SumOfGidits GetSumOfGidits(value);
    if (GetSumOfGidits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfGidits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}