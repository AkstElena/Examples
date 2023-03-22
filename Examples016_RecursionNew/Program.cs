// собрать строку с числами от а до b, а <= b

// Итеральный подход
string NumbersFor(int a, int b)
{
  string result = String.Empty;
  for (int i = a; i <= b; i++)
  {
    result += $"{i} ";
  }
  return result;
}

// Рекурсия
string NumbersRec(int a, int b)
{
  if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
  else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));
Console.WriteLine();

// Сумма чисел от 1 до N

int SumFor(int n)
{
  int result = 0;
  for (int i = 1; i <= n; i++)
    result += i;
  return result;
}

int SumRec(int n)
{
  if (n == 1) return 1;
  else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
Console.WriteLine();

// Факториал числа

int FactorialFor(int n)
{
  int result = 1;
  for (int i = 1; i <= n; i++)
    result *= i;
  return result;
}

int FactorialRec(int n)
{
  if (n == 1) return 1;
  else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));
Console.WriteLine();

// Возвести число а в степень n

int PowerFor(int a, int n)
{
  int result = 1;
  for (int i = 1; i <= n; i++)
  {
    result = result * a;
  }
  return result;
}

int PowerRec(int a, int n)
{
  // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // Если записать тернарным оператором
  if (n == 0) return 1;
  else return PowerRec(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));

// Улучшить пример с помощью сокращения операций возведения в степень

int PowerRecMath(int a, int n)
{
  if (n == 0) return 1;
  else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
  else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(2, 10));

// Перебор слов. В некотором машинном алфавите имеются четрые буквы а, и, с и в.
// Покажите все слова сосотяшие из Т букв, которые можно построить из букв этого алфавита

// char [] s = {'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//   for (int j = 0; j < count; j++)
//   {
//     for (int k = 0; k < count; k++)
//     {
//       for (int l = 0; l < count; l++)
//       {
//         Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}"); // для четырехбуквенных слов слов
//       }
//     }
//   }
// }

int n = 1; // счетчик для количества результатов
void FindWords(string alphabet, char[] word, int length = 0)
{
  if (length == word.Length)
  {
    Console.WriteLine($"{n++} {new String(word)}"); return;
  }
  for (int i = 0; i < alphabet.Length; i++)
  {
    word[length] = alphabet[i];
    FindWords(alphabet, word, length + 1);
  }
}

FindWords("аисв", new char[5]);


