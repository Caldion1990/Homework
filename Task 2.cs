//Задача 2. Напишите программу,которая на вход принимает два числа и выдает, 
//какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.Readline());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.Readline());

if (n1 > n2) {
    Console.WriteLine("Первое число больше второго");
}
else if (n2 > n1)
{
    Console.WriteLine("Второе число больше первого");
}
else if (n1 == n2) {
    Console.WriteLine ("Числа равны");
}