// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,]array = CreateArray(3,10);
PrintArray(array);
System.Console.WriteLine();
PrintArray(SortingArrayElements(array));

int [,] CreateArray(int length1, int length2)
{
    int[,] numbers = new int[length1, length2];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i,j] = new Random().Next(1 ,10);
        }
    }
    return numbers;
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write(numbers[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] SortingArrayElements(int[,] numbers)
{
    for (int bubble = 0; bubble < numbers.GetLength(1); bubble++)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1)-1; j++)
            {
                if (numbers[i,j] < numbers[i,j+1])
                {
                    int temp = numbers[i,j];
                    numbers[i,j] = numbers[i,j+1];
                    numbers[i,j+1] = temp;
                }
            }
        }
    }
    return numbers;
}