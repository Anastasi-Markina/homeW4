void PrintArray(int[]array) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]}");
    }
}
int[] FillArray(int size)
{
    int[] a = new int[size];
    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0,9);
    }
    return a;
}
int[] myArray = FillArray(8);
PrintArray(myArray);
