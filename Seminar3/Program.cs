//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// void GetDiapazone(int quadrant)
// {
//     if(quadrant == 1) Console.WriteLine("X > 0 and Y > 0");
//     else if(quadrant == 2) Console.WriteLine("X < 0 and Y > 0");
//     else if(quadrant == 3) Console.WriteLine("X < 0 and Y < 0");
//     else if(quadrant == 4) Console.WriteLine("X > 0 and Y < 0");
//     else Console.WriteLine("Wrong input!");
// }

// Console.Write("Input a number of quadrant: ");
// int quadrant = Convert.ToInt32(Console.ReadLine());
// GetDiapazone(quadrant);



//1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
//и выдаёт номер четверти плоскости, в которой находится эта точка.
// int GetQuadrant(int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;
//     return -1;
// }


// Console.Write("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetQuadrant(x, y));

//2. Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.

// void Method1(int number){
//     int x = 1;
//     while(x <= number)
//     {
//         Console.Write($"{Math.Pow(x, 2)} ");
//         x++;
//     }
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Method1(number);

//3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// double Method1(int x1, int x2, int y1, int y2)
// {
//     return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// }


// Console.Write("Input X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Method1(x1, x2, y1, y2));

//HomeWork
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool IsPalindrome(int number)
// {
//     int dig;
//     int temp = number;
//     int rev = 0;

//     while(number > 0)
//     {
//         dig = number % 10;
//         rev = rev * 10 + dig;
//         number /= 10;
//     }
//     if(temp == rev) return true;
//     return false;
// }
// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(IsPalindrome(number)) Console.WriteLine("Y");
// else Console.WriteLine("N");
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// double Method1(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
// }


// Console.Write("Input X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y1: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Method1(x1, x2, y1, y2, z1, z2));

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// void Method1(int number){
//      int x = 1;
//      while(x <= number)
//     {
//         Console.Write($"{Math.Pow(x, 3)} ");
//         x++;
//     }
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Method1(number);