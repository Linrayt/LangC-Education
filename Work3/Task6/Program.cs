//ЗАДАЧА:
//Сообщить о наличии отрицательных элементах в строках двумерного массива.

int[,] table = {{-1,1,1,2,6},
            {2,2,27,6,4},
            {3,3,-3,7,12} };
for (int i = 0; i < table.GetLength(0); i++)
    {
    for (int j = 0; j < table.GetLength(1); j++)
    {
        if (table[i, j] < 0)
        {
            Console.WriteLine($"There are negative elements in line {i}");
            break;
        }
    }
}
