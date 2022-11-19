// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



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

int[,] MultiplicationMatrixArray(int[,] array, int[,] array2)
{   
    int[,] result = new int [array.GetLength(0), array2.GetLength(1)];
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array2.GetLength(1); j++)
            {
                for(int n = 0; n < array2.GetLength(0); n++)
                {
                    result[i, j] += array[i, n] * array2[n, j];
                }
            }
        }
        return result;
}



Console.Clear();
int[,] array = GetArray(2, 2);
PrintArray(array);
Console.WriteLine();
int[,] newarray = GetArray(2, 2);
PrintArray(newarray);
int[,] inArray = MultiplicationMatrixArray(array, newarray);
Console.WriteLine();
PrintArray(inArray);