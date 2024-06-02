//ЗАДАЧА:
//Назовем число "интересным" если его сумма цифр ЧЁТНАЯ.
//Создание двумерного массива, состоящего из целых чисел.
//Вывести на экран "интересные" элементы массива.


int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] Matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return Matrix;
}

void ShowMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write($"{Matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Matrix = CreateMatrix(3, 4);
ShowMatrix(Matrix);
foreach (int e in Matrix)
{
    if (isintresting(e) == true);
    {
        Console.WriteLine(e);
    }
}

bool isintresting(int value)
{
    int SumOfGidits = GetSumOfGidits(value);
    if (SumOfGidits % 2 == 0)
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