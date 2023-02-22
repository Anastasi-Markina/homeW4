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

bool CheckIn(int[,] matrix, int r, int c)
{
    if (r >= matrix.GetLength(0) || c >= matrix.GetLength(1) || r < 0 || c < 0)
        {
            return false;
        }
    return true;
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

int r = ReadInt("введите номер строки: ");
int c = ReadInt("введите номер столбца: ");

if (CheckIn(array, r, c))
{
    Console.WriteLine($"элемент: {array[r,c]}");
}
else
{
    Console.WriteLine("элемент не найден");
}