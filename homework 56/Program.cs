Console.WriteLine("Введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
void CreateArray(int m, int n)
{
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
}
void Summ(int m, int n)
{
    int i, j;
    int index = 0;
    int min = int.MaxValue;
    for (i = 0; i < m; i++)
    {
        int sum = 0;
        for (j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            index = i + 1;
        }
        Console.WriteLine(sum);
    }
    Console.WriteLine($"Саммая маленькая сумма : {min}, она находится на строке : {index}");
}
CreateArray(3, 4);
Summ(3, 4);