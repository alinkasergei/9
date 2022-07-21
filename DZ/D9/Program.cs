/*// Задача 64: Задайте значение N. Напишите программу, 
//которая найдет факториал числа N рекурсивным методом. N = 4 -> 24
int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
System.Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n}! = {Factorial(n)}");

// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfDigits(int m, int n)
{
    if (m == n)
        return n;
    return n + SumOfDigits(m, n - 1);
}
System.Console.WriteLine("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма элементов " + (SumOfDigits(m, n))); */
