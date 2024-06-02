//ЗАДАЧА
//Выдать на экран сообщение в случае наличия в массиве нечетного числа.
//2,4,6 - компелятор проверил, на 7 он остановился с помощью break.

Console.WriteLine("Start");

int[] numbers = { 2, 4, 6, 7, 8, 10, 13, 16, 17, 24 };
foreach (int number in numbers)
{
    if (number % 2 == 1)
    {
        Console.WriteLine("There is odd number");
        break;
    }
}

Console.WriteLine("Stop");