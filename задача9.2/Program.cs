// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m, n);

// void AkkermanFunction (int m, int n)
// {
//     Console.Write (Akkerman (m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//        return n++;
//     }
//     else if (m > 0 && n==0)
//     {
//         return Akkerman(m--,1);
    
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack (m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack (m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write (input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}