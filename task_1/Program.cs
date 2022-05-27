// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("Давайте найдем точку пересечения двух прямых!");
Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = " ";
double y = " ";
double сoordinateX = x;
double сoordinateY = y;


 y = k1 * x + b1;
 y = k2 * x + b2;

 y - y = k1 * x + b1 - (k2 * x + b2);
 y = k2 * x + b2;

 

  
 
 Console.Write ($"Точка пересечения двух прямых имеет координаты {(x, y)};




