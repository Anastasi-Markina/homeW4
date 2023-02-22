
void PrintArray(double[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.Write("\n");
    }
}


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int rows = ReadInt("введите количество строк");
int cols = ReadInt("введите количество столбцов");

Random rand = new Random();

double[,] array = new double[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = rand.NextDouble();
    }
}

PrintArray(array);