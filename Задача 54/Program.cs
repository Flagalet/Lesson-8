// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
 // элементы каждой строки двумерного массива.

int[,] GetArray(int line, int column)
{
    int[,] array = new int[line, column];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random(). Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i ++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }           
}

void PrintStreamlineArray(int[,] inArray)
{
    
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            for(int k = 0; k < inArray.GetLength(1) - 1; k++)
            {
                if(inArray[i, k] < inArray[i, k + 1])
                {
                    int temp = inArray[i, k + 1];
                    inArray[i, k + 1] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }
        }
    }
}
Console.Clear();
int[,] array = GetArray(4, 4);
PrintArray(array);
PrintStreamlineArray(array);
Console.WriteLine();
PrintArray(array);