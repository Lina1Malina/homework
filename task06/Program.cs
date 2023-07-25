// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt16(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}
if ((number % 2 == 0))
{
    int result = number % 2;
    Console.WriteLine("Число четное ");
}
else
{
    Console.WriteLine("Число не является четным");
}
