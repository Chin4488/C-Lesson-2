// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите трёхзначное число");
int Number = Convert.ToInt32(Console.ReadLine());
int NumberB = Number / 10;
int Result = NumberB % 10;
Console.WriteLine($"Вторая цифра числа - {Result}");