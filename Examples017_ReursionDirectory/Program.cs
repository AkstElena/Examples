// Найти папку в папке

// string path = "/Elena/GeekBrains/C#/Examples/Example001_HelloConsole"; 
// DirectoryInfo di = new DirectoryInfo(path);

// System.Console.WriteLine(di.CreationTime);

// FileInfo [] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//   System.Console.WriteLine(fi[i].Name);
// }


// Рекурсия хождения по папкам для поиска файлов

void CatalogInfo(string path, string indent = "") // в качестве аргумента путь к текущей папке, второй аргумент искуственный прием позволяющий видеть структуру папки
{
  DirectoryInfo catalog = new DirectoryInfo(path); // информация о папке, к которой указали путь

  DirectoryInfo[] catalogs = catalog.GetDirectories(); // массив всех файлов находящихся в папке
  for (int i = 0; i < catalogs.Length; i++) // проходим по всем файлам внутри папки
  {
    Console.WriteLine($"{indent}{catalogs[i].Name}");
    CatalogInfo(catalogs[i].FullName, indent + " "); // рекурсивно заходим во все папки внутри папки
  }
  FileInfo[] files = catalog.GetFiles(); // Получаем весь список файлов запрошенной папки
  for (int i = 0; i < files.Length; i++)
  {
    Console.WriteLine($"{indent}{files[i].Name}"); // выводим весь список файлов
  }
}

string path = "/Elena/GeekBrains/C#/Examples/Example001_HelloConsole";
CatalogInfo(path);