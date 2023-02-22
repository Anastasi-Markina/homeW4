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

double[] CalculateMean(int[,] matrix)
{
    double[] answer = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            answer[j] += Convert.ToDouble(matrix[i, j])/matrix.GetLength(0);
        }
    }
    return answer;
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
double[] means = CalculateMean(array);
for (int i = 0; i < cols; i ++)
{
    System.Console.WriteLine($"Среднее арифметическое {i} столбца = {means[i]}");
}