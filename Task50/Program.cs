/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

Task50();

void Task50()
{
    Random random = new Random();
    int rows = random.Next(5, 15);
    int column = random.Next(5, 15);
    int[,] array = new int[rows, column];
    FillArray(array);
    Console.WriteLine("Вывод массива");
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    FindElement(array);

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
            array[i, j] = random.Next(-100, 100);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array)
{
    Console.WriteLine("Введите номер строки искомого элемента");
    int findRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца искомого элемента");
    int findColumn = Convert.ToInt32(Console.ReadLine());
    int rows = array.GetLength(0);
    int column = array.GetLength(1);
    if (findRow <= rows && findRow > 0 && findColumn <= column && findColumn > 0)
    {
        Console.WriteLine("Значение элемента: " + array[findRow - 1, findColumn - 1]);
    }
    else Console.WriteLine("Данного элемента не существует");
}