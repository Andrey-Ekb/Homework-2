// Найти расстояние между точками в пространстве.

Console.Clear();

Console.WriteLine("Задаем координаты точек в диапозоне (от -10 до 10)");

int x1=new Random().Next(-10,10);
int y1=new Random().Next(-10,10);
int x2=new Random().Next(-10,10);
int y2=new Random().Next(-10,10);

Console.WriteLine();
Console.WriteLine(" Координаты первой точки - ("+x1+","+y1+")");
Console.WriteLine(" Координаты втлрой точки - ("+x2+","+y2+")");

double x=(x2-x1)*(x2-x1);
double y=(y2-y1)*(y2-y1);

double Rez=Math.Sqrt(x+y);

Console.WriteLine("Расстояние между точками составляет - "+Rez.ToString("0.00"));
Console.WriteLine();


