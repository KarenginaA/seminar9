//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// void ShowNum(int num)
// {
//     Console.Write(num +" ");
//     if(num > 1) ShowNum(num -1 );

// }
// ShowNum(10);

//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// int SumOfElements(int m, int n)
// {
//     int sum = m;
//     if (m == n)
//     {
//         return 0;
//     }
//     m++;
//     sum = m + SumOfElements(m, n);
//     return sum;
// }

// Console.Write("Введите число m: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write(SumOfElements(M - 1, N));

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//m=2 n=3

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (n == 0 && m > 0)
//         return AkkermanFunction(m - 1, 1);
//     return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
// }

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(AkkermanFunction(m, n));


