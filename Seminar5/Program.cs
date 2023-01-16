//task 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    ShowArray(array);
    return array;
}

void ShowArray(int[] array) {
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumNeg(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i] < 0)
        {
            result += array[i];
        }
    }
    return result;
}

// Console.WriteLine(SumNeg(CreateRandomArray(12, -9, 9)));

//task 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
bool IsConsumed(int checkedNumber, int[] array){
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == checkedNumber)
        {
            return true;
        }
    }
    return false;
}
// Console.Write("Input the desired number ");
// Console.Write(IsConsumed(Convert.ToInt32(Console.ReadLine()), CreateRandomArray(10, 0, 10)));

//task 3: Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
int SumSegment(int[] array, int segmentA, int segmentB)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= segmentA && array[i] <= segmentB) result++;
    }
    return result;
}

// Console.WriteLine("Input the segment [a - b]");
// Console.Write("Input the segment [a]: ");
// int segmentA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input the segment [b]: ");
// int segmentB = Convert.ToInt32(Console.ReadLine());

// Console.Write(SumSegment(CreateRandomArray(10, 0, 10), segmentA, segmentB));

//home work
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int EvenCount(int[] array){
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) result++;
    }
    return result;
}

//Console.Write($"Number of even numbers {EvenCount(CreateRandomArray(10, 100, 999))}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int ToSumOfOddIndices(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

//Console.Write($"Sum of odd indices: {ToSumOfOddIndices(CreateRandomArray(10, 0, 10))}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    ShowDoubleArray(array);
    return array;
}

void ShowDoubleArray(double[] array) {
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double toMax(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double toMin(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
Console.Write($"Target array: ");
double[] array = CreateRandomDoubleArray(5, 0, 10);

double min = toMin(array);
Console.WriteLine($"Min: {min}");

double max = toMax(array);
Console.WriteLine($"Min: {max}");

Console.Write($"number difference: {max - min}");