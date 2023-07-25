// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число:");
int number1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число:");
int number2 = Convert.ToInt16(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} большее число. {number2} меньшее.");
}
else 
{
    Console.WriteLine($"{number2} большее число. {number1} меньшее.");
}
