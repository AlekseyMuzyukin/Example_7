double [] sum1 = new double [4];
double [] res =new double [4];
int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
int c = 3;
PrintMatrix(array2D);
SummIndex(array2D,c);
Console.WriteLine("Среднее арифмитическое каждого столбца");
PrintArray2(res);


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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} | ");
            
        }
        Console.WriteLine("");
    }
}

void SummIndex(int[,] matrix,int c)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum1 [j] += matrix[i, j];
            res[j] = Math.Round(sum1[j] / c,1);
        }
    }
}

void PrintArray2(double [] res)
{
    for (int i = 0; i <= res.Length - 2; i++) Console.Write($"{res[i],5} ");
    Console.Write($"{res[res.Length - 1],4}");
}