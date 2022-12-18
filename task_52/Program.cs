// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetMatrix(int rowsCount, int columnsCount, int LeftRange=0, int rightRange=50)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i, j] = rand.Next(LeftRange, rightRange + 1); 
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Task(int[,] matr)
{
    double sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i,j];
        }
        Console.Write($"сумма {j} столбца = {sum/4}");
        Console.WriteLine();
    }
}

int[,] matr = GetMatrix(3, 4, 3, 9);
PrintMatrix(matr);
Task(matr);