// 9. Напишите программу,которая 1.выводит случайно число из
// отрезка [10, 99] и 2.показывает наибольшую цифру числа.

// 78->8
// 12->2
// 85->8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// int digit1 = number / 10;
// int digit2 = number % 10;

// if(digit1 > digit2) Console.WriteLine($"Наибольшая цифра числа -> {digit1}");
// else Console.WriteLine($"Наибольшая цифра числа -> {digit2}");

// int maxdigit = digit1 > digit2 ? digit1 : digit2;
// Console.WriteLine($"Наибольшая цифра числа -> {maxdigit}");


int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {result}");


int MaxDigit(int num)
{
    int digit1 = num / 10;
    int digit2 = num % 10;
    int maxdigit = digit1 > digit2 ? digit1 : digit2;
    return maxdigit;
}