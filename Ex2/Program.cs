/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int start = ReadInt("Введите число M: ");
int end = ReadInt("Введите число N: ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от {start} до {end} равна: " + sum(start, end));

int sum(int m, int n)
{
    if (m == n)
        return n;
    return n + sum(m, n - 1);
}

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
