// Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] GetArray(int line, int column)
{
    int k = 1;
    int[,] array = new int[line, column];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = k;
            k++;
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
            if(inArray[i, j] < 10) Console.Write($"0{inArray[i, j]}\t");
             
            else Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }           
}

void PrintSpirallyArray(int[,] inArray)
{
    int temp = 1, i = 0, j = 0;
    while (temp<= inArray.GetLength(0) * inArray.GetLength(1))
    {
        inArray[i, j] = temp;
        temp++;
        if (i <= j+1 && i+j< inArray.GetLength(1)-1)
        j++;
        else if (i < j && i+j>= inArray.GetLength(0)-1)
        i++;
        else if (i >= j && i+j> inArray.GetLength(1)-1)
        j--;
        else 
        i--;
        }

    for ( i = 0; i < inArray.GetLength(0); i++)
        {
        for ( j = 0; j < inArray.GetLength(1); j++)
            {
            if(inArray[i, j] < 10) Console.Write($"0{inArray[i, j]} \t");
            else  Console.Write($"{inArray[i, j]} \t");
            }
        Console.WriteLine();
        }
    }
Console.Clear();
int[,] array = GetArray(4, 4);
PrintArray(array);
Console.WriteLine();
PrintSpirallyArray(array);
