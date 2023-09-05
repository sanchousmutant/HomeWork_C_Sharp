// Задача 43: Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Intersection(int b1, int k1, int b2, int k2)
{
    if (k1 == k2) System.Console.WriteLine("Точки пересечения нет - прямые параллельны");
    else if (b1 == b2) System.Console.WriteLine($"Точка пересечения (0, {b1})");
    else
    {
        double x = (b2 - b1) * Math.Pow(k1 - k2, -1);
        double y = k1 * x + b1;
        System.Console.WriteLine($"Точка пересечения ({x}, {y})");
    }
}

int b1 = InputNum("Введите коэффициент b1: ");
int k1 = InputNum("Введите коэффициент k1: ");
int b2 = InputNum("Введите коэффициент b2: ");
int k2 = InputNum("Введите коэффициент k2: ");
Intersection(b1, k1, b2, k2);