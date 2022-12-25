int number;
while (true)
{
    Console.Write("Введите целое пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
    if (number > 10000 && number < 100000)
        break;
    Console.WriteLine("Ошибка ввода!");
}

int a1 = number / 10000;
int a2 = number % 10;
int b1 = (number / 1000) % 10;
int b2 = (number % 100) / 10;

if(a1 == a2 && b1 == b2)
    Console.WriteLine($"Число {number} -> является палиндромом");
else
    Console.WriteLine($"Число {number} -> не является палиндромом");