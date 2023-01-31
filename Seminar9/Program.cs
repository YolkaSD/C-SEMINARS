//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

//ShowNums(5);
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int GetSumDigits(int num)
{
    if(num != 0) return GetSumDigits(num / 10) + num % 10;
    else return 0;

}
//Console.WriteLine(GetSumDigits(12345));
//f(1234) -> 4 + f(123)
//f(123) -> 3 + f(12)
//f(12) -> 2 + f(1)
//f(1) -> 1 + f(0)
//f(0) -> 0

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNums2d(int num1, int num2)
{
    if(num1 < num2)
    {
        Console.Write(num1 + " ");
        ShowNums2d(num1 + 1, num2);
    }
    else if(num1 > num2)
    {
        Console.Write(num2 + " ");
        ShowNums2d(num1, num2 + 1);
    }
    else{
        Console.WriteLine(num1);
    }
}

//ShowNums2d(-14, 12);

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
// 2^4 = 2 * 2 * 2 * 2
// a ^ b = a * a * a * a
// f(2, 4) -> 2 * f(2, 3)
// f(2, 3) -> 2 * f(2, 2)
// f(2, 2) -> 2 * f(2, 1)
// f(2, 1) -> 2
int Pow(int a, int b)
{
    if(b != 1)
    {
        return Pow(a, b - 1) * a;
    }
    return 2;
}

//Console.WriteLine(Pow(2, 4));

//Home work
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumsReverse(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNumsReverse(num - 1);
    
}

//ShowNumsReverse(8);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int m, int n)
{
    if(m <= n)
    {
        return GetSum(m + 1, n) + m;
    }
    return 0;
}

//Console.WriteLine(GetSum(4, 8));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunc(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
		
Console.WriteLine(AkkermanFunc(3,2));
