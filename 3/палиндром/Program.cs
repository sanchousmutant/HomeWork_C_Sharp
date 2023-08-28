//проверяет пятизначное число number является ли оно палиндромом

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

bool IsPalindrome(int number)
{
    if(number < 10000 | number > 99999)
        {
            System.Console.WriteLine("Число не пятизначное");
            return false;
        }
    else return number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10;
}

int num = InputNum("Введите пятизначное число: ");
bool res = IsPalindrome(num);
System.Console.WriteLine(res);