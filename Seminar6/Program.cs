// void ShowNum(int[] a)
// {
//     a[0] += 5;
//     Console.WriteLine(a[0]);
// }

// int[] num = {5, 7, 3};
// ShowNum(num);
// Console.WriteLine(num[0]);

//task Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//треугольник существует если сумма длин двух сторон > длины третей стороны
bool DoesTriangleExist(int a, int b, int c)
{
    if(a + b > c && a + c > b && b + c > a)
    {
        return true;       
    }
    return false;
}

// Console.WriteLine("Enter the sides of the triangle");
// Console.Write("A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("C: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(DoesTriangleExist(a, b, c));

//task Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
int[] FirstFibonacciNumbers(int a, int b, int size)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i < size; i ++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }

    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

// Console.Write("Input a first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FirstFibonacciNumbers(a, b, size);
// PrintArray(array);

//task Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++) 
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

// int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
// int[] copyArray = CopyArray(array);
// array[0] = 100;
// PrintArray(array);
// PrintArray(copyArray);


//home work:
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountNumbersGreaterThenZero(){
    Console.Write("Enter number of digits: ");
    int lengthNumbers = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for (int i = 0; i < lengthNumbers; i++)
    {
        Console.Write($"Enter digit {i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) 
        {
            sum++;
        }
    }
    Console.Write("Count numbers greater then zero: " + sum);
}

//CountNumbersGreaterThenZero();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if(k1 == k2) 
    {
        Console.Write("Given lines do not intersect!");
    }
    else
    {
        Console.Write($"Point of intersection of the given lines: ({x}; {y})");
    }
}

Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

CrossPoint(k1,b1,k2,b2);
