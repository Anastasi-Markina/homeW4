
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

int[,] SortDesc(int[,] matrix)
{
    int[,] answer = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int[] temp = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j] = matrix[i, j];
        }
        Array.Sort(temp);
        Array.Reverse(temp);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            answer[i, j] = temp[j];
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
System.Console.WriteLine("\nДо сортировки:");
PrintArray(array);
int[,] sortedArray = SortDesc(array);
System.Console.WriteLine("\nПосле сортировки:");
PrintArray(sortedArray);
