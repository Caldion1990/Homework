// Написать программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    int a = i % 2;
    if (a == 0)
    {
        Console.Write(i + " ");
    }
}