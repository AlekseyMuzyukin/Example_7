double[,] array1 = new double[3, 4];
InputMatrixArray(array1);
PrintMatrix(array1);


void InputMatrixArray(double[,] array, int minsize = -10, int maxsize = 10)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= array.GetLength(1) - 1; j++)
            array[i, j] = Math.Round(rnd.NextDouble() * (maxsize - minsize) + minsize, 1);
    }
}

void PrintMatrix(double[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j], 4} | ");
            
        }
        Console.WriteLine("");
    }
}