int[,] CreateRandom2dArray()
{
    // Console.Write("Input a number of rows: ");
    // int rows = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input a number of colums: ");
    // int columns = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input a min possible value: ");
    // int minValue = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input a max possible value: ");
    // int maxValue = Convert.ToInt32(Console.ReadLine());
    int rows = 4;
    int columns = 4;
    int minValue = 0;
    int maxValue = 9;


        int[,] array = new int[rows, columns];
        for(int i = 0; i < rows; i++) 
            for(int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(minValue, maxValue +1);

        return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");   
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowDouble2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");   
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

//int[,] myArray = CreateRandom2dArray();
//Show2dArray(myArray); 

//task 1 Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
int[,] CreateAij2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
        for(int i = 0; i < rows; i++) 
            for(int j = 0; j < columns; j++)
                array[i, j] = i + j;

        return array;
}

//int[,] array = CreateAij2dArray();
//Show2dArray(array);

//task 2 Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
void PowEvenIndex(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2) {
        for(int j = 0; j < array.GetLength(1); j+=2) {
            array[i, j] = (int) Math.Pow(array[i, j], 2);
        }
    }   
}

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// PowEvenIndex(array);
// Show2dArray(array);

//task 3 Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Главная диагональ - элементы главного индекса [1,1] [2,2] [3,3] [4,4] ..
int SumMainDiagonal(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,i];
    }

    return sum;
}


// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// Console.WriteLine(SumMainDiagonal(array));

//home work
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] CreateDoubleRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        double[,] array = new double[rows, columns];
        for(int i = 0; i < rows; i++) 
            for(int j = 0; j < columns; j++){
                double number = new Random().NextDouble();
                double number2 = (double) Math.Round(minValue + number * (maxValue - minValue + 1), 2);
                if(number2 > maxValue) number2 = maxValue;
                array[i, j] = number2;
            }  

        return array;
}

// double[,] myArray = CreateDoubleRandom2dArray();
// ShowDouble2dArray(myArray); 

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
int ArrayExistence(int[,] array, int indX, int indY) {
    if(indX >= array.GetLength(0) || indY >= array.GetLength(1)) return -1;
    return array[indX, indY];
}
// int[,] array = CreateRandom2dArray();
// Console.Write("Enter element position X: ");
// int indX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter element position Y: ");
// int indY = Convert.ToInt32(Console.ReadLine());
// Show2dArray(array);
// Console.WriteLine(ArrayExistence(array, indX, indY));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
double[] AverageColumn(int[,] array)
{
    double[] avgArray = new double[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(1); i++) {
        double sum = 0;
        for(int j = 0; j < array.GetLength(1); j++) {
            sum += array[j, i];
        }
        avgArray[i] = sum / array.GetLength(1);
    }

    return avgArray;
}

void PrintAvgArray(double[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
double[] abgArray = AverageColumn(array);
PrintAvgArray(abgArray);