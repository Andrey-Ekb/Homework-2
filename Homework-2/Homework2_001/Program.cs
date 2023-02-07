// Дано число обозначающее день недели. Выяснить, является ли день недели выходной.

Console.Clear();

Console.Write("Введите номер дня недели (от 1до 7) ");
int Number=int.Parse(Console.ReadLine() ?? "0");
Number--;

Console.WriteLine();
string[]array={"Понедельник","Вторник","Срела","Четверг","Пятница","Суббота","воскресенье"};
if(Number>4) Console.WriteLine("Выходной день - "+array[Number]);
else Console.WriteLine("Рабочий д6рь: "+array[Number]);

Console.WriteLine();

