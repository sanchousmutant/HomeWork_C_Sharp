// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumDigits(int M, int N)
{
    if (M > N) return 0;
    return M + SumDigits(++M, N);
}


int numFirst = InputNum("Введите первое число: ");
int numSecond = InputNum("Введите второе число: ");
int sum = SumDigits(numFirst, numSecond);
System.Console.WriteLine(sum);