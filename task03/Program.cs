// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число: ");
int week = Convert.ToInt32(Console.ReadLine());
if (week == 1)
{
System.Console.WriteLine("Понедельник");
}
else if (week == 2)
{
System.Console.WriteLine("Вторник");
}
else if (week == 3)
{
System.Console.WriteLine("Среда");
}
else if (week == 4)
{
System.Console.WriteLine("Четверг");
}
else if (week == 5)
{
System.Console.WriteLine("Пятница");
}
else if (week == 6)
{
System.Console.WriteLine("Суббота");
}
else if (week == 7)
{
System.Console.WriteLine("Воскресенье");
}
else 
{
System.Console.WriteLine("Введите число от 1 до 7");
}