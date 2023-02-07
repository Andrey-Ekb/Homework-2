// По двум заданным числам проверить, является ли одно квадратом другого.

Console.Clear();

Console.Write("Введите первое число - ");
int Number1=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите квадрат первого - ");
int Number2=int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

if (Number2==Number1*Number1) Console.WriteLine(Number2+" является квадратом числа "+Number1);
else Console.WriteLine(Number2+" неявляется квадратом числа "+Number1);
Console.WriteLine();

