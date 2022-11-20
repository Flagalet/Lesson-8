// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] GetArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int s = 0; s < array.GetLength(2); s++)
            {
                int number = new Random(). Next(10, 100);
                if (SearchNumberArray(array, number))
                {
                    break;
                }
                array[i, j, s] = number;
            }
        }
    }
    return array;
}

bool SearchNumberArray (int[,,] inArray, int num)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            for(int s = 0; s < inArray.GetLength(2); s++)
            {
                if(inArray[i, j, s] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void PrintArray(int[,,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i ++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.WriteLine();
            for(int s = 0; s < inArray.GetLength(2); s++)
            {
                Console.Write($"{inArray[i, j, s]} ({i}, {j}, {s})\t ");
            }
            
        }

    }           
}

Console.Clear();
int[,,] array = GetArray(2, 2, 2);
PrintArray(array);