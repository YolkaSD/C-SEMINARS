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
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("The first number is greater: ");
}
else if(num1 == num2)
{
    Console.WriteLine("The numbers are equal");
}
else
{
    Console.WriteLine("The second number is more: ");
}