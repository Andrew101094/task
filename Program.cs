// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки массива. 
// Например:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге:
// 7 4 2 1 
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array); 
Console.WriteLine();
SortRow(array);
PrintArray(array); 

int[,] GetArray(int m, int n, int min, int max)    //задаем рендомный массив
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortRow(int[,] inArray)                                      
{
    for (int i = 0; i < inArray.GetLength(0); i++)                        
    {
        for (int j = 0; j < inArray.GetLength(1); j++)                    
        {
            for (int n = 0; n < inArray.GetLength(1) - 1; n++)
            {
                if (inArray[i, n] > inArray[i, n + 1])           //первый элемент сравниваем с последующим и если он больше, то проваливаемся в if
                {
                int k = inArray[i, n + 1];                       //временная переменная k которая фиксирует первое значение
                inArray[i, n + 1] = inArray [i,n];
                inArray[i, n] = k;
                }
            }    
        }
    }
}