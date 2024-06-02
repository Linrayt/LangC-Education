//ЗАДАЧА:
//Если тебе нужно произвести 5 итераций, но на 3 проводить не надо, ее можно скипнуть с помощью оператора передачи управления - continue.

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Iteration {i} ");
    if (i == 3)
    {
        Console.WriteLine("Skip");
        continue;
    }
    Console.WriteLine("Some processing");
}