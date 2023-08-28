// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int InputNum(string message) // функция ввода
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Array(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i <= size - 1; i++)
    {
        array[i] = rnd.Next(99);
    }
    System.Console.WriteLine("[{0}]", string.Join(", ", array));
}

int size = InputNum("Введите размер массива: ");
Array(size);