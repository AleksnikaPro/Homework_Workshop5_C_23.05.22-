//2. Написать программу масштабирования фигуры.
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) например: "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

// Вариант 1

/*Console.WriteLine("Давайте масштабируем фигуру.");
Console.WriteLine("Введите значение координаты x1: ");
double x1 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение координаты y1: ");
double y1 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение координаты x2: ");
double x2 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение координаты y2: ");
double y2 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение координаты x3: ");
double x3 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение координаты y3: ");
double y3 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение координаты x4: ");
double x4 = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите значение координаты y4: ");
double y4 = double.Parse(Console.ReadLine()?? "0");

Console.WriteLine("Введите коэффициент маштабирования k: ");
double k = double.Parse(Console.ReadLine()?? "0");


x1 = x1 * k;
y1 = y1 * k;
x2 = x2 * k;
y2 = y2 * k;
x3 = x3 * k;
y3 = y3 * k;
x4 = x4 * k;
y4 = y4 * k;

Console.WriteLine($"Координаты масштабированной фигуры {(x1,y1)},{(x2,y2)},{(x3,y3)},{(x4,y4)} при коэффициенте масштабирования k = {k}.");*/


// Вариант 2

Console.Clear();
Console.WriteLine("Давайте масштабируем четырехугольник!");
Console.Write("Введите коэффициент маштабирования k: ");
double k = double.Parse(Console.ReadLine()?? "0");
Console.WriteLine();

double[,] array = new double[4,2]; 
for (int i = 0; i < 4; i++)
{
    Console.Write($"Введите координату x{i + 1}: ");
    array[i,0] = double.Parse(Console.ReadLine()?? "0");
    Console.Write($"Введите координату y{i + 1}: ");
    array[i,1] = double.Parse(Console.ReadLine()?? "0");
    
}

Console.WriteLine();
Console.WriteLine("Координаты до масштабирования:");
double[,] newArray = new double [4,2];
for (int i = 0; i < 4; i++) 
{  
        newArray[i,0] = array[i,0] ;
        newArray[i,1] = array[i,1] ;
        Console.Write($"x{i+1}: {newArray[i,0]}, y{i+1}: {newArray[i,1]} ");
        Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Координаты после масштабирования:");
double[,] scalingArray = new double [4,2];
for (int i = 0; i < 4; i++) 
{  
    scalingArray[i,0] = newArray[i,0] * k;
    scalingArray[i,1] = newArray[i,1] * k;
    Console.Write($"x{i+1}: {scalingArray[i,0]}, y{i+1}: {scalingArray[i,1]} ");   
    Console.WriteLine();
}


// Вариант 3 (на основе Лекции №6 Сергея Камянецкого)


/*using System.Linq;
Console.Clear();
string coordinates = "(0,0) (2,0) (2,2) (0,2)"
       .Replace("(","") // заменяем "(" на пустую строку "" 
       .Replace(")","")
       ;

Console.WriteLine("Координаты до масштабирования:");
Console.WriteLine("(0,0) (2,0) (2,2) (0,2)");
Console.WriteLine();

Console.WriteLine("Координыты после масштабирования:");
int scalingFactor = 2;//коэффициент масштабирования

var arrayOfCoordinates = coordinates.Split(" ")
                    .Select(item => item.Split(','))
                    .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // массив кортежей
                    .ToArray();
for (int i = 0; i < arrayOfCoordinates.Length; i++)
{
    Console.Write($"({arrayOfCoordinates[i].x * scalingFactor},{arrayOfCoordinates[i].y * scalingFactor}) ");// при выводе координаты уже числа
   
}
Console.WriteLine();*/