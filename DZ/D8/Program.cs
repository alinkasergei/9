// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*void SortElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                if (array[i, a] < array[i, a + 1])
                {
                    int temp = array[i, a + 1];
                    array[i, a + 1] = array[i, a];
                    array[i, a] = temp;
                }
            }
            System.Console.Write(array[i, j] + " ");

        }
        System.Console.WriteLine();
    }
}
int[,] CreateRandomArray(int rows, int columns, int minV, int maxV)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(minV, maxV + 1);
    return newArray;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write(array[i, j] + " ");
        System.Console.WriteLine();
    }
}
int[,] myArray = CreateRandomArray(5, 5, 0, 9);

ShowArray(myArray);
Console.WriteLine("Отсортированный массив: ");
SortElements(myArray);
System.Console.WriteLine();
ShowArray(myArray);*/

//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*int[,] CreateRAndomArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int rowNumber(int[,] array)
{
    int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) result = sum;
        else if (sum < result)
        {
            result = sum;
            index = i;
        }
    }
    return index;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

int[,] myArray = CreateRAndomArray(4, 4, 0, 9);
ShowArray(myArray);
System.Console.WriteLine("Строка с найменьшей суммой элементов: ");
int index = rowNumber(myArray);
System.Console.WriteLine(index);*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/* void CreateRAndomArray(int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            matr1[i, j] = new Random().Next(1, 10);
        }
    }
}

void ShowArray(int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            Console.Write($"{matr2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            Console.Write($"{matr2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Composition(int[,] matr1, int[,] matr2, int[,] compMatr)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            compMatr[i, j] = matr1[i, j] * matr1[i, j];
        }
    }
}

void PrintCompArray(int[,] compMatr)
{
    for (int m = 0; m < compMatr.GetLength(0); m++)
    {
        for (int n = 0; n < compMatr.GetLength(1); n++)
        {
            Console.Write($"{compMatr[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = new int[4, 4];
int[,] matrix2 = new int[4, 4];
int[,] compMatrix = new int[4, 4];
CreateRAndomArray(matrix1, matrix2);
ShowArray(matrix1, matrix2);
Console.WriteLine();
Composition(matrix1, matrix2, compMatrix);
PrintCompArray(compMatrix); */
