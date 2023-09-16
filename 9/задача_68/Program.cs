// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Ackermann(int m, int n)
{
    while (m != 0)
    {

        if (n == 0) n = 1;
        else n = Ackermann(m, n - 1);
             
        m = m - 1;  
    }
    return n + 1;
}

int m = InputNum("Введите первое число: ");
int n = InputNum("Введите второе число: ");
System.Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");