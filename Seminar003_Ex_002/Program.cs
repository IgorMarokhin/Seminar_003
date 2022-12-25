Console.Clear();
Console.WriteLine("Введите номер четверти (от 1 до 4): ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num == 1)
    Console.WriteLine("X > 0, Y > 0");
else if (num == 2)
    Console.WriteLine("X < 0, Y > 0");
else if (num == 3)
    Console.WriteLine("X < 0, Y < 0");
else if (num == 4)
    Console.WriteLine("X > 0, Y < 0");
else
    Console.WriteLine("Ошибка! Введено не корректное число!");