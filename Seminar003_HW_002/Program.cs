Console.Clear();

Console.Write("Введите значение X для точки A: ");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите значение Y для точки A: ");
int y1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите значение Z для точки A: ");
int z1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите значение X для точки B: ");
int x2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите значение Y для точки B: ");
int y2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите значение Z для точки B: ");
int z2 = int.Parse(Console.ReadLine() ?? "");

double distance0 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
double distance = Math.Round(distance0, 2);

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {distance}");