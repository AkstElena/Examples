// string[,] table = new string[2, 5];

// индексы начинаются с нуля.
// Самый первый элемент будет с [0, 0].
// Последний элемент [1, 4] (т.е. элемент во второй строке пятого столбца)
// String.Empty - по умолчанию строковые массивы будут пустыми

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)  // цикл для строк
// {
//   for (int columns = 0; columns < 5; columns++) // цикл для столбцов
//   {
//       Console.WriteLine($"-{table[rows, columns]}-");  //интрополяция, вывести двумерную таблицу со значениями в соответствующей строке и столбце 
//   }
// }



// void PrintArray(int[,] matrix)
// {
//   for (int rows = 0; rows < matrix.GetLength(0); rows++)
//   {
//     for (int columns = 0; columns < matrix.GetLength(1); columns++)
//     {
//       Console.Write($"{matrix[rows, columns]} "); //пишем на одной строке значения колонок
//     }
//     Console.WriteLine(); // чтобы начать с новой строки строку
//   }
// }

// void FillArray(int [,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(-99, 100);    
//     }
//   }
// }

// int[,] matr = new int[3, 4];
// PrintArray(matr);
// Console.WriteLine();
// FillArray(matr);
// PrintArray(matr);


// int[,] img = new int[,]
// {
//   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
//   {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//   {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//   {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
//   {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//   {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//   {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
//   {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
//   {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
//   {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
//   {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0},
//   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
// };

// void PrintImg(int[,] image)
// {
//   for (int rows = 0; rows < image.GetLength(0); rows++)
//   {
//     for (int columns = 0; columns < image.GetLength(1); columns++)
//     {
//       if (image[rows, columns] == 1)
//         Console.Write(" *");
//       else Console.Write("  ");
//     }
//     Console.WriteLine();
//   }
// }

// PrintImg(img);

// void FillImg(int row, int col)
// {
//   if (img[row, col] == 0)
//   {
//     img[row, col] = 1;
//     FillImg(row - 1, col);
//     FillImg(row, col - 1);
//     FillImg(row + 1, col);
//     FillImg(row, col + 1);
//   }
// }

// FillImg(15, 15);
// PrintImg(img);


// int Factorial(int n)
// {
//   if (n == 1) return 1; // 1! = 1
//   else return n * Factorial(n-1);
// }

// Console.WriteLine(Factorial(5));


// int Factorial(int n)
// {
//   if (n == 1) return 1; // 1! = 1
//   else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//   Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// double Factorial(int n)
// {
//   if (n == 1) return 1; // 1! = 1
//   else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//   Console.WriteLine($"{i}! = {Factorial(i)}");
// }


//Последовательность Фибонначи f(n) = f(n-1) + f (n-2)

double Fibonachi(int n)
{
  if (n == 1 || n == 2) return 1;
  else return Fibonachi(n - 1) + Fibonachi(n - 2);
}
for (int i = 1; i < 50; i++)
{
  Console.WriteLine($"f({i}) = {Fibonachi(i)}");
}