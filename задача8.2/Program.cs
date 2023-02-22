
void PrintArray(int[,] matrix)

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

int FindMinRow(int[,] matrix)
{
    int sum;
    int minRow = -1;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if(i == 0 || sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int rows = ReadInt("введите количество строк: ");
int cols = ReadInt("введите количество столбцов: ");

Random rand = new Random();

int[,] array = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = rand.Next(0, 10);
    }
}
PrintArray(array);
int minRow = FindMinRow(array);
System.Console.WriteLine($"Номер минимальной строки - {minRow}");

