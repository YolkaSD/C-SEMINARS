// Семинар 1.

// Задача 1.

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad2 = num2 * num2;

// if(num1 == quad2)
// {
//     Console.WriteLine("Yes");
// }
// else 
// {
//     Console.WriteLine("No");
// }

//Задача 2.

// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int current = -number;

// while(current <= number)
// {
//     Console.Write($"{current} ");
//     current++;
// }

//Home Work Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.WriteLine("The first number is greater: ");
// }
// else if(num1 == num2)
// {
//     Console.WriteLine("The numbers are equal");
// }
// else
// {
//     Console.WriteLine("The second number is more: ");
// }

//Home Work Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// int[] arrayNum = new int[3];
// Console.Write("Input a first number: ");
// arrayNum[0] = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// arrayNum[1] = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a third number: ");
// arrayNum[2] = Convert.ToInt32(Console.ReadLine());

// int maxNumber = arrayNum[0];
// for(int i = 1; i < arrayNum.Length; i ++)
// {
//     if(maxNumber < arrayNum[i]) 
//     {
//         maxNumber = arrayNum[i];
//     }
// }

// Console.WriteLine($"The largest number is: {maxNumber}");

//Home Work Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 2 == 0) 
// {
//     Console.Write($"{num} Number even");
// } 
// else
// {
//     Console.Write($"{num} Number not a even");
// }