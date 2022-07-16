/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
округлёнными до одного знака. */

Task47();

void Task47()
{
    Console.WriteLine("Введите количество строк в массиве");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве");
    int column = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, column];
    FillArray(array);
    PrintArray(array);

}

void FillArray(double[,] array)
{
    int rows = array.GetLength(0);
    int column = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = Math.Round(random.Next(-1000, 1000) * random.NextDouble(), 1);
        }
    }
}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}