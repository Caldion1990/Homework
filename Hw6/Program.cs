// Задача 6. Напишите программу, которая на вход принимает число и выдает, 
//является ли число четным (делится ли оно на 2 без остатка).

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n % 2;
if (a == 0)
{
    Console.Write("четное");
}
else
{
    Console.Write("нечетное");
}
