// Задача 4. Напишите программу, которая принимает на вход 3 числа и выдает максимальное из них.

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2) 
    if (n1 > n3)
    {
    Console.WriteLine("Первое число максимальное");
    }
    else {
    Console.WriteLine("Третье число максимальное");
    }
else
    if (n2 > n3) 
    {
        Console.WriteLine ("Второе число максимальное");
    }
    else
    {
        Console.WriteLine ("Третье число максимальное");
    }   