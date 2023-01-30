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
            Console.Write(array[i, j] + "  ");   
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

//task Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
void ChangeRows(int[,] array, int row1, int row2) {
    if(row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 <array.GetLength(0) && row1 != row2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int tmp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = array[tmp, j];
        }
    }
}

// ChangeRows(myArray, 0, myArray.GetLength(1) - 1);
// Show2dArray(myArray);

//task Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// 3 1 5 -> 3 7 2
// 7 4 9 -> 1 4 6
// 2 6 8 -> 5 9 8
void Reverse(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++) {
            int tmp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = tmp;
        }
            
    }
}
// Reverse(myArray);
// Show2dArray(myArray);


//task Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
//1. Найти первый наименьший элемент
int[] SearchFirstMinPositiion(int[,] array)
{
    int[] minPos = {0, 0};
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 1; j < array.GetLength(1); j++)
        {
            if(array[i, j] < array[minPos[0], minPos[1]])
            {
                minPos[0] = i;
                minPos[1] = j;
            }
        }

    return minPos;
}
//удалить строку и столбец
int[,] DeleteRowsAndColumn(int[,] array, int[] minPos)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for(int i = 0, x = 0; i < array.GetLength(0); i++, x++)
    {
        if(i == minPos[0]) {
            x--;
            continue;
        } 
        else
        {
            for(int j = 0, y = 0; j < array.GetLength(1); j++, y++)
            {
                if(j == minPos[1]) {
                    y--;
                    continue;
                }
                else
                {
                    newArray[x, y] = array[i, j];
                }
            }
        }
        
    }
    return newArray;
}

// myArray = DeleteRowsAndColumn(myArray, SearchFirstMinPositiion(myArray));
// Show2dArray(myArray);

//HOMEWORK
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Ascending(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1) - 1;)
            {
                if(array[i, j] < array[i, j + 1])
                {
                    int tmp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = tmp;
                    j = 0;
                } 
                else
                {
                    j++;
                }
            }
        }
}

// Ascending(myArray);
// Show2dArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int Smallest(int[,] array)
{
    int smalStr = 0;
    int sum1 = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        {
            int sum2 = 0;
            for(int j = 0; j < array.GetLength(1); j++)
            {
                sum2 += array[i,j];

                if(i == 0 ) 
                {
                    sum1 = sum2;
                }
            }
            
            if(sum1 > sum2) 
            {
                sum1 = sum2;
                smalStr = i;
            } 
            
            
        }
    return smalStr + 1;
} 

// Console.WriteLine(Smallest(myArray));
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
    
int[,] Product(int[,] matrix1, int[,] matrix2)
{
    int[,] productMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    
    for(int i = 0; i < matrix1.GetLength(0); i++) {
        for(int j = 0; j < matrix2.GetLength(0); j++)
        {
            productMatrix[i,j] = 0;
            for (int k = 0; k < matrix1.GetLength(0); k++)
                {
                    productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
        }
    }

    return productMatrix;
}
// int[,] matrix1 = myArray;
// int[,] matrix2 = CreateRandom2dArray();
// Show2dArray(matrix2);
// int[,] prMat = Product(matrix1, matrix2);
// Show2dArray(prMat);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateRandom3dArray()
{
    int rows = 2;
    int columns = 2;
    int deep = 2;
    int minValue = 0;
    int maxValue = 9;

        int[,,] array = new int[rows, columns, deep];
        int number = 10;
        for(int i = 0; i < rows; i++) 
            for(int j = 0; j < columns; j++)
                for(int h = 0; h < deep; h++)
                    array[i, j, h] = ++number;

        return array;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            for(int h = 0; h < array.GetLength(0); h ++) {
                Console.Write($"{array[i, j, h]} ({j}, {h}, {i}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

// int[,,] my3dArray = CreateRandom3dArray();
// Show3dArray(my3dArray);

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiral() 
{
    int rows = 4;
    int columns = 4;

    int[,] array = new int[rows, columns];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= rows * columns)
    {
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < rows - 1)
        j++;
    else if (i < j && i + j >= rows - 1)
        i++;
    else if (i >= j && i + j > rows - 1)
        j--;
    else
        i--;
    }

    return array;
}


void ShowSpiral(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] < 10)
      {
    Console.Write($"0{array[i,j]} ");
      }
      else 
      {
        Console.Write($"{array[i,j]} ");
      }
    }
    Console.WriteLine();
  }
}



int[,] spiral = CreateSpiral();
ShowSpiral(spiral);
