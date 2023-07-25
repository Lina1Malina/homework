//1.Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5->да
// a = 2, b = 10->нет
// a = 0, b = -3 ->да
// a = -3, b = 9->да

Console.WriteLine("Введите два целых числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine($"Является квадратом числа {number1} ");
} else {
    Console.WriteLine("Квадрат не равен");
}