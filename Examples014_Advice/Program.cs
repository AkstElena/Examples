// Узнать тип данных

// int a = 12;
// Console.WriteLine(a.GetType());

// int d = 12;
// Console.WriteLine(d.GetType().Name);

using System.Linq;

// var b = 12;
// Console.WriteLine(b.GetType().Name);

// var data = new int[] { 1, 2, 3, 4 }
//           .Where(e => e > 0)
//           .Select(e => new { q = e, w = e + 1 });

// Console.WriteLine(data.GetType().Name);


void DrawText(string text, int left, int top)
{
  Console.SetCursorPosition(left, top);
  Console.WriteLine(text);
}
//Так нельзя из-за магических чисел!!!
//DrawText("Intensive C# Demo text", 629, 360)

string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2; // Определить начало текста по середине экрана по ширине
int screenHeighPosition = Console.WindowHeight / 2; // Определить начало текста по середине экрана по высоте
DrawText( // При таком оформлении удобнее делать потом замену
  text: caption,
  left: screenWidthPosition,
  top: screenHeighPosition
  );