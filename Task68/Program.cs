// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckermannFunc(m,n));

int AckermannFunc(int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 & n == 0) return AckermannFunc(m-1, 1);
    else if (m > 0 & n > 0) return AckermannFunc(m-1, AckermannFunc(m, n-1));
    return 0;
}