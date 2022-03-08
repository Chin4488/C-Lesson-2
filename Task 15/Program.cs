// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int Kratno7 = Number % 7;
int Kratno23 = Number % 23;
if (Kratno7 == 0 & Kratno23 == 0) {
    Console.WriteLine("Введенное число кратно 7 и 23");
}   else {
    Console.WriteLine("Введенное число некратно 7 и 23");
}