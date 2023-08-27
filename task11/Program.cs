// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 1000 -> {number}");
int result = DeleteSecondDigit(number);//метод
Console.WriteLine($"Без второй цифры: {result}");

int DeleteSecondDigit(int num)
 {
    int digit1 = num / 100;
    int digit3 = num % 10;

    return digit1 * 10 + digit3;
 }