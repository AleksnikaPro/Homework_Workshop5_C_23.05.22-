// 1.Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


//уравнения y = k2 * x + b2 и k1*(b2-b1)/(k1-k2)+b1 имеют один и тот же результат при вычислении


//Вариант 1

Console.WriteLine("Давайте найдем точку пересечения двух прямых!");
Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()?? "0");

double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;

if (k1 != k2)
{
  x = (b2-b1)/(k1-k2);
  y = k1*(b2-b1)/(k1-k2)+b1;
  Console.Write($"Точка пересечения двух прямых имеет координаты x = {Math.Round((x),2)}, y = {Math.Round((y),2)}.");
}
else
{
    Console.Write($"Прямые не пересекаются(параллельны), так как k1 = k2.");
}


/*Вариант 2 

double k1 = 5;
double k2 = 12;
double b1 = 2;
double b2 = 6;

double x=(b2-b1)/(k1-k2); 
double y=k1*(b2-b1)/(k1-k2)+b1;

Console.Write($"Точка пересечения двух прямых имеет координаты x = {Math.Round((x),2)}, y = {Math.Round((y),2)}.");*/
 
 
 

