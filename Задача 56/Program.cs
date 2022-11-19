// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] GetArray(int line, int column)
{
    int[,] array = new int[line, column];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random(). Next(1, 100);
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

void MinSumLineArray(int[,] array)
{
    int sum = 0;
    int n = 0;
    int k = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = array[i, j] + sum;   
        }
            if( sum < n)
                {
                    k = i;
                    n = sum;
                }
            if(i == 0)
            {
                n = sum;
            }

            Console.WriteLine($"Сумма чисел {i+1} строки = {sum}");
            sum = 0;
    }
    Console.WriteLine();
    Console.Write($"Строка с наименьшей суммой элементов {k+1}");
}


Console.Clear();
int[,] array = GetArray(4, 6);
PrintArray(array);
Console.WriteLine();
MinSumLineArray(array);