/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. */

Task52();

void Task52()
{
    Random random = new Random();
    int rows = random.Next(5, 8);
    int column = random.Next(5, 8);
    int[,] array = new int[rows, column];
    FillArray(array);
    Console.WriteLine("Вывод массива");
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    Average(array);

}

void FillArray(int[,] array)
{
    int rows = array.GetLength(0);
    int column = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.Next(5, 20);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Average(int[,] array)
{
    int rows = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < column; i++)
    {
        int sum = 0;
        for (int j = 0; j < rows; j++)
        {   
            sum = sum + array [j, i];
        }
        Console.WriteLine("Сумма среднего арифметического элементов в " + (i+1) + " столбце равна " + (sum/rows));
    }
}    