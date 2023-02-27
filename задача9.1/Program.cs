System.Console.WriteLine("введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Print(m,n,0);

void Print (int numM, int numN, int sum)
{
    sum += numN;
    if (numN<numM)
    {
    
        return;
    }
    
    Print (numM, numN - 1, sum);

    System.Console.Write(sum +"  ");
}