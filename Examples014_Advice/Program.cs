// Узнать тип данных

// int a = 12;
// Console.WriteLine(a.GetType());

// int d = 12;
// Console.WriteLine(d.GetType().Name);

using System.Linq;

// var b = 12;
// Console.WriteLine(b.GetType().Name);

var data = new int[] { 1, 2, 3, 4 }
          .Where(e => e > 0)
          .Select(e => new { q = e, w = e + 1 });

Console.WriteLine(data.GetType().Name);
