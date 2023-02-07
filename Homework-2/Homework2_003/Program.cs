// Задать номер четверти, показать диапозон для возможных координат.

Console.Clear();

Console.Write("Введите номер четверти (от 1 до 4) - ");
int Number=int.Parse(Console.ReadLine() ?? "0");
string Range="" ?? "0";

Console.WriteLine();

if (Number==1) Range="(x>o, y>0)";
if (Number==2) Range="(x<o, y>0)";
if (Number==3) Range="(x<o, y<0)";
if (Number==4) Range="(x>o, y<0)";

Console.WriteLine(Number+" - четверти соответствует диапозон "+ Range);
Console.WriteLine();