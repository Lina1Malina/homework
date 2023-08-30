// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет



int m = 4; //Convert.ToInt32(Console.ReadLine());
int n = 4; //Convert.ToInt32(Console.ReadLine());
int [,] array = new int[m, n];
Console.WriteLine("Введите размеры массива: ");
int number = Convert.ToInt32(Console.ReadLine());
FillArray (array);
FindElementArray (array, number);

void FillArray (int[,] arrayToFill)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)  
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++) 
        {
            array [i,j] = new Random().Next(1, 10);
            Console.Write(array [i,j] + " ");
        } 
        Console.WriteLine();
    }
}

void FindElementArray (int [,] findElement, int usernumber)
{
    bool find = false;
    for (int i = 0; i < findElement.GetLength(0); i++)  
    {
        for (int j = 0; j < findElement.GetLength(1); j++) 
        {
            if (findElement [i,j] == usernumber)
            Console.WriteLine($"Ваше число находится по координатам {i},{j} ");
            find = true;
        } 
    }
    if (!find) Console.WriteLine("Такого значения нет.");
}