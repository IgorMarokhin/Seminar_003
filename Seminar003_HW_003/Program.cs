int N;

try
{
    Console.Write("Введите целое число: ");
    N = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}
Console.Write($"{N} -> ");

for (int count = 1; count < N; count++)
{
    Console.Write($"{Math.Pow(count,3)}, ");
}
Console.WriteLine($"{Math.Pow(N,3)}. ");