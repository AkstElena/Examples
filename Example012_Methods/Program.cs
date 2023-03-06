// Вид 1
void Method1()
{
  Console.WriteLine("Автор ....");
}

//Method1();

// Вид 2
void Method2(string msg)
{
  Console.WriteLine(msg);
}

//Method2("Текст сообщения");

void Method21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}

//Method21(msg:"Текст", count: 4);
//Method21(count: 4, msg:"Новый текст");

// Вид 3
int Method3()
{
  return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4
// string Method4(int count, string text)
// {
//   int i =0;
//   string result = String.Empty;

//   while (i<count)
//   {
//     result = result + text;
//     i++;
//   }
//   return result;
// }


string Method4(int count, string text)
{
  string result = String.Empty;
  for (int i = 0; i < count; i++)
  {
    result = result + text;
  }
  return result;
}

string res = Method4(10, "fdkc");
//Console.WriteLine(res);


//Таблица умножения
// for (int i = 2; i < 10; i++)
// {
//   for (int j = 2; j <= 10; j++)
//   {
// //     Console.WriteLine($"{i} * {j} = {i * j}");
//   }
//   Console.WriteLine(); //абзац
// }


//======= Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" аменить большими "К",
// а большие "С" заменить мальнькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
// s[3] = r

string RePlase(string text, char oldValue, char newValue)
{
  string result = String.Empty;
  int lenght = text.Length;
  for (int index = 0; index < lenght; index++)
  {
    if (text[index] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[index]}";
  }

  return result;
}

// string newText = RePlase(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// string newСText = RePlase(newText, 'С', 'с');
// Console.WriteLine(newСText);
// Console.WriteLine();

// string newкText = RePlase(newСText, 'к', 'К');
// Console.WriteLine(newкText);


// Сортировка массива от минимального элемента к максимальному

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) //метод для вывода массива
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length-1; i++) //вычитаем 1, так как в цикле внутри j = i+1
  {
    int minPosition = i;

    for (int j = i + 1; j < array.Length; j++) //ищем минимальную позицию
    {
      if (array[j] < array[minPosition]) minPosition = j;
    }

    int temporary = array[i];   //перестановка местами с минимальным
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
  Console.WriteLine();
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
