// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

int GetNumber(string message) 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] matr = GetMatrix(3, 4, 3, 9);
PrintMatrix(matr);
int row = GetNumber("Введите индекс элемента в строке");
int column = GetNumber("Введите индекс элемента в столбце");
if (row >=3)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
if (column >=4)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
    Console.WriteLine($"Ваше число {matr[row, column]}");





