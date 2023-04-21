// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = GetParameters("количество строк массива");
int n = GetParameters("количество столбцов массива");

FinalResult(m, n);

int GetParameters(string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}


bool RectangularArray (int rows, int columns)
{
    if (rows != columns) return true;
    else return false;
}

void FinalResult(int rows, int columns)
{
    if (RectangularArray (rows, columns))
    {
        int[,] numbers = CreateArray(rows, columns);
        PrintArray(numbers);
        SummElementOfRow(numbers);
    }
    else
    {
        System.Console.WriteLine("Массив квадратный. Условия не соблюдены");
    }
}

int[,] CreateArray(int rows, int columns)
{
    int[,] numbers = new int[rows, columns];
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


void SummElementOfRow(int[,] numbers)
{
    int min = 1000;
    int rows = 0;
    
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            result += numbers[i,j];
        }
        if (result < min)
        {
            min = result;
            rows = i;
        }
        System.Console.WriteLine($"Сумма элементов в строке {i} = {result}");
    }
    System.Console.WriteLine($"Строка с наименьшей суммой элементов - {rows}");
}

