decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
  fRec++;
  return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n) // decimal предоставляет наибольшее количество значащих цифр для числа.
// Он поддерживает до 29 значащих цифр и может представлять значения, превышающие 7,9228 x 10 ^ 28.
// Он особенно подходит для вычислений, например финансовых, которые нуждаются в большом количестве цифр, но не могут допускать ошибки округления. Значение по умолчанию для типа Decimal — 0
{
  fIte++;
  decimal result = 1;
  decimal f0 = 1;
  decimal f1 = 1;
  for (int i = 2; i <= n; i++)
  {
    result = f0 + f1;

    f0 = f1;
    f1 = result;
    fIte++;
  }
  return result;
}


Console.ReadLine();
DateTime dt = DateTime.Now; // время до запуска программы
for (int n = 10; n < 40; n++)
{
  Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}"); // fIte - показываем сколько итераций цикла произошло для решения
}
Console.WriteLine((DateTime.Now-dt).TotalMilliseconds); // подсчет времени работы программы в миллисекундах

Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
  Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}"); // ToString("### ### ###"), -15  это красивый вывод
  fRec = 0;
}
Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);
