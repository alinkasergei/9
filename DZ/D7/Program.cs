// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

/*double [,] CreateArray(int m, int n, int minV, int maxV)
{
    double[,] newArray = new double[m, n];

    for (int i = 0; i < m; i++) //проверка элементов в строке
        for (int j = 0; j < n; j++) // проверка элементов в столбце
            newArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;

    return newArray;
}

void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) //проверка элементов в строке
    {
        for (int j = 0; j < array.GetLength(1); j++) // проверка элементов в столбце
            System.Console.Write(array[i, j] + " ");

        System.Console.WriteLine();
    }
}

System.Console.Write("Input m : ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Input n : ");
int n = Convert.ToInt32(System.Console.ReadLine()); 

double[,] myArray = CreateArray(m, n, -9, 9);
ShowArray(myArray); */

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int[,] CreateArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(1, 9);
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "   ");
        Console.WriteLine();
    }

}
void FindNum(int[,] newArray)
{
    Console.WriteLine("Input first number: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input second number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m >= newArray.GetLength(0) || n >= newArray.GetLength(1))
        Console.WriteLine("Number isn't found");
    else Console.WriteLine("The number is " + newArray[m, n]);
}

int[,] myArray = new int[4, 4]; 

CreateArray(myArray);
ShowArray(myArray);
FindNum(myArray); */

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

/* void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
             array[i, j] = new Random().Next(1, 6);
    }
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");

        Console.WriteLine();
    }
}
void FindAverageNumber(int[,] newArray)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < newArray.GetLength(0); i++) 
        average += newArray[i, j];
        Console.WriteLine($"The averege number of {j + 1} column is: {average / newArray.GetLength(0)}");
    }
}

int[,] array = new int[5, 5];

CreateArray(array);
ShowArray(array);
FindAverageNumber(array);*/