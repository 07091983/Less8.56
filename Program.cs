// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
//1 строка

int[,] matr = new int[4,4] ;
void PrintArray (int[,] matr)
{   
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

void SumInLines (int[,] matr) //Сумма чисел строки
{
    //int sumInLines = new int[matr.GetLength(0)];
    Console.Write("\nСуммы чисел строки: ");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j]; 
        }
        Console.Write($"{sum} ");
    }
    
}

void  minSum (int[] numbers) // Определение номера строки, по наименьшей сумме строки
{ 
    int min = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers [i] <= min)
        {
           min = numbers [i];
        }
    }
    return;
    
}

int min = 0;
Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {min}");

int[,] matrix = new int [4,4];
PrintArray (matr);
FillArray (matr);
SumInLines(matr);
Console.WriteLine();
PrintArray (matr);
