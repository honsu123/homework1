// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}
int[,] SortRevers(int[,] initArray)
{
    for (int  i= 0; i < initArray.GetLength(0); i++)
    {
        for (int j = 0; j < initArray.GetLength(1); j++)
        {
            for (int k = 0; k < initArray.GetLength(1) - 1; k++)
            {
                if (initArray[i, k] < initArray[i, k + 1])
                {
                    int temp = initArray[i, k + 1];
                    initArray[i, k + 1] = initArray[i, k];
                    initArray[i, k] = temp;
                }
            }
        }
    }
    return initArray;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(SortRevers(CreateArray(3, 4)));
