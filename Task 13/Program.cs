// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber % SecondNumber == 0){
    Console.WriteLine("Кратно");
}   else  {
        Console.WriteLine($"Остаток -> {FirstNumber % SecondNumber}");
    }
