// int CutNumber(int number) 
// {
//     int sot = number / 100;
//     int ed = number % 10;
//     int result = sot * 10 + ed;
//     return result;
// }

// bool IsEven(int num)
// {
//     if(num % 2 == 0) 
//     {
//         return true;
//     }
//     else 
//     {
//         return false;
//     }
// }

// int number = new Random().Next(100, 1000);
// int newNumber = CutNumber(number);
// Console.WriteLine($"Current random three-digit number is {number}");
// Console.Write($"New version of number is {newNumber}");

// 


// Задача 1  Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int IsMax(int number)
// {
//     // number 73
//     int num1 = number / 10; // 7
//     int num2 = number % 10; // 3

//     if(num1 > num2)
//     {
//         return num1;
//     }
//     else
//     {
//         return num2;
//     }
// }

// int number = new Random().Next(10, 100);
// int numMax = IsMax(number);
// Console.WriteLine(number);
// Console.WriteLine(numMax);

// Задача 2. 
// Напишите программу, которая будет принимать на вход два числа и определять, является ли второе число кратным первому
// bool IsQuad(int num1, int num2)
// {
//     if(num2 % num1 == 0) 
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.Write("Input is a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input is a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"number is {IsQuad(num1, num2)}");

//3. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// bool IsQuad(int num1, int num2)
// {
//     if(num1 * num1 == num2 || num2 * num2 == num1) 
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.Write("Input is a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input is a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(IsQuad(num1, num2));


//HomeWork Seminar 2

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// int SecondNumberOfThreeDigit(int number)
//     {
//     if(number < 100 || number > 999)
//     {
//         Console.WriteLine($"The number {number} is not three-digit");
//         return -1;
//     }

//     return number / 10 % 10;
// }

// Console.Write("Pls, enter a three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The second number is {SecondNumberOfThreeDigit(number)}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// int ThirdNumber(int number)
// {
//     int hundredsCount = number / 100;
//     if(hundredsCount == 0)
//     {
//         return -1;
//     }
//     int remainder = 1;
//     while(hundredsCount > 0) 
//     {
//      hundredsCount /= 10;
//      remainder *= 10;
//     }
//     return number % remainder / (remainder / 10);

// }
// Console.Write("Pls, enter a three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(ThirdNumber(number) == -1)
// {
//     Console.WriteLine($"The number {number} is not three digits");
// }
// else
// {
//     Console.Write($"The three-digit of {number} = {ThirdNumber(number)}");
// }
