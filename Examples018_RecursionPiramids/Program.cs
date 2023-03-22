// Переместить блинчики пирамидки с одного шпиля на другой по цветам

void Towers(string with = "1", string on = "3", string some = "2", int count = 3) // with - откуда берем блинчик, on - куда собираем, count - сколько блинов всего, some - промежуточный шпиль
{
  if (count > 1) Towers(with, some, on, count - 1);
  Console.WriteLine($"{with} >> {on}");
  if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
Console.WriteLine();

// Посчитать выражение (4 - 2) * (1 + 3) / 10
string emp = String.Empty;
string [] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                  0    1    2     3    4     5   6    7    8    9     10   11   по бинарному дереву (в лекции) 
// описываем логику обхода дерева

void InOrderTraversal(int pos = 1)   // позиция для начала проверки
{
  if (pos < tree.Length)  //  когда позиция превысит количество узлов в дереве, рекурсия закончится
  {
    int left = 2 * pos; // позиция левого поддерева
    int right = 2 * pos + 1; // позиция правого поддерева
    if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // проверка наличия левого поддерева и что элемент не является пустым, тогда обходим рекурсивно левое поддерево
    Console.WriteLine(tree[pos]);
    if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right); // проверка наличия правого поддерева и что элемент не является пустым, тогда обходим рекурсивно правое поддерево
  }
}

InOrderTraversal();
