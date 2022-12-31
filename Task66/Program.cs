// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRecursion(int begin, int end)
{
    if (begin == end) return end;
    return (begin + SumRecursion(begin + 1, end));
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterData("Введите число: ");
int n = EnterData("Введите число: ");
Console.WriteLine(SumRecursion(m, n));
