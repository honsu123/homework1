Console.WriteLine("Напишите размер трёхмерного массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m, n, b];
void CreateArray(int m, int n, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) {" "}");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
CreateArray(m, n, b);