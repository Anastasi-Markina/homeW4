System.Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int c = 0;
if (a>9)
{
    while (a>0)
    {
         int b = a%10;
         a/=10;
         c = c + b;
    }
System.Console.WriteLine(c);
}
else
{
    System.Console.WriteLine(a);
}