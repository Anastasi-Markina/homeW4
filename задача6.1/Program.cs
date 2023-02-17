Console.Write("Введите числа");
int[] numbers = StringNum(Console.ReadLine());
PrintArray(numbers);
int positive = 0;
for (int i = 0; i < numbers.Length; i++)
{
 if (numbers[i] > 0)
    {
 positive++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {positive}");


int[] StringNum(string array)
{
 int a = 1;
 for (int i = 0; i < array.Length; i++)
    {
 if (array[i] == ' ')
        {
    a++;
        }
    }

 int[] numbers = new int [a];
 int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        var b = "";

        while (array[i] != ' ')
        {
        if(i != array.Length - 1)
        {
            b += array [i].ToString();
            i++;
        }
        else
        {
            b += array [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(b);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)

{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}




























