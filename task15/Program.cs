// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
void week (int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("этот день - выходной");
    }
    else if (number < 1 || number >7) 
    {
        Console.WriteLine("введите число от 1 до 7");
    }
    else 
    Console.WriteLine("этот день не выходной");
}
week(number);