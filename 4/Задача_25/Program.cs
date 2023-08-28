// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int InputNum(string message) // функция ввода
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Exponentiation(int num1, int num2)
{
    int res = 1;
    for (int i = 1; i <= num2; i++)
    {
        res *= num1;
    }
    return res;
}

int numberFirst = InputNum("Введите первое число: ");
int numberSecond = InputNum("Введите второе число: ");
int exp = Exponentiation(numberFirst, numberSecond);
System.Console.WriteLine(exp);