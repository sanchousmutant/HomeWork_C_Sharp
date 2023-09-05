// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


using System.Security.Cryptography;

void PositiveNumbers()
{
    int size = new Random().Next(5, 11);

    System.Console.WriteLine($"Введите {size} чисел:");

    int count = 0;

    for (int i = 1; i <= size; i++)
    {
        if (int.Parse(Console.ReadLine()!) > 0) count++;
    }

    System.Console.WriteLine($"Попалось {count} чисел больше нуля");
}


PositiveNumbers();