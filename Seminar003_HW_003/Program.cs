Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine() ?? "");

for (int count = 1; count <= N; count++)
{
    Console.Write($"{count * count * count}, ");
}
Console.WriteLine(".");