// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("enter n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum = {SumNM(n, m)}");

int SumNM (int N, int M)
{
    int sum = 0;
    if (N == M) return M;
    return sum += N + SumNM(N+1, M);
}

