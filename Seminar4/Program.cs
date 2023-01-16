// int GetSum(int num)
// {
//     int sum = 0;

//     for(int current = 1; current <= num; current++)
//     {
//         sum += current;
//     }

//     return sum;
// }
// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = GetSum(a);
// Console.WriteLine(result);

//Task 1 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// int NumberOfDigits(int number)
// {
//     int count = 0;

//     if(number == 0) {
//         count = 1;
//     }

//     // while(number != 0)
//     // {
//     //     count++;
//     //     number /= 10;
//     // }

//     for(; number != 0; number /= 10){
//         count++;
//     }

//     return count;
// }

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = NumberOfDigits(a);
// Console.WriteLine(result);

//Task 2 Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// int Method1(int number)
// {
//     int result = -1;
//     if(number == 1)
//     {
//         result = 1;
//     }
//     else
//     {
//         result = number *  Method1(number - 1);
//     }
    
//     return result;
//     }

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Method1(a);
// Console.WriteLine(result);

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return array;
// }

// void ShowArray(int[] array) {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of elements: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(m, min, max);
// ShowArray(newArray);


//Home Work
//task: 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
// int MyPow(int a, int b)
// {
//     int tmp = a;
//     for(int i = 1; i < b; i++)
//     {
//         a *= tmp;
//     }
//     return a;
// }

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number pow: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = MyPow(a, b);
// Console.WriteLine(result);

//task  27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum(int number)
// {
//     int result = 0;
//     while(number != 0)
//     {
//         int tmp = number % 10;
//         number /= 10;
//         result += tmp;
//     }
//     return result;
// }

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Sum(a);
// Console.WriteLine(result);

//task 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// int[] CreateArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Input a {i} element of array: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }

//     return array;
// }

// void ShowArray(int[] array) {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of elements: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateArray(m);
// ShowArray(newArray);