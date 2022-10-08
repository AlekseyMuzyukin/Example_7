Console.WriteLine("Введите координаты элемента ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
int m = 3;
int n = 4;

SerchIndex(array2D, a, b, m, n);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void SerchIndex(int[,] array2D, int a, int b, int m, int n)
{
    if (a >= 0 && b > 0)
    {
        if (a <= m && b <= n)
        {
            object? c = array2D.GetValue(a-1, b-1);
            Console.WriteLine($"====>{c}");
        }

        else
        {
            Console.WriteLine("такого элемента в массиве нет");
        }
    }
    else
    {
        Console.WriteLine("Введите положительное число");
    }

}