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

Console.WriteLine("Давайте масштабируем фигуру!");
Console.WriteLine("Введите коэффициент маштабирования k: ");
double k = double.Parse(Console.ReadLine()?? "0");

double[,] array = new double [4,2]; // на каждой строке по две координаты Х и У.
for (int i = 0; i < 4; i++) // array.GetLength(0)
{
    for (int j = 0; j < 2; j++) //array.GetLength(1)
    {
        Console.WriteLine("Введите координату:");
        array[i,j] = double.Parse(Console.ReadLine()?? "0");
        //Console.WriteLine("Введите координату y:");
        //array[i,j] = double.Parse(Console.ReadLine()?? "0");
    }
    
}
Console.WriteLine();
Console.WriteLine("Координаты до масштабирования:");
double[,] newArray = new double [4,2];
for (int i = 0; i < array.GetLength(0); i++) // 4
{
    for (int j = 0; j < array.GetLength(1); j++) // 2
    {
      
        newArray[i,j] = array[i,j];
        Console.Write($"{array[i,j]} ");  
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Координаты после масштабирования (коэффициент масштабирования = {k}):");
double[,] scalingArray = new double [4,2];
for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        scalingArray[i,j] = newArray[i,j] * k;
        Console.Write($"{scalingArray[i,j]}  ");
       
    }
    Console.WriteLine();
}   
