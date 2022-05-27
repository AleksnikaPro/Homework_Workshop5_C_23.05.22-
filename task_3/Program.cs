//3. Написать программу копирования массива 

Console.Clear();
Console.WriteLine("Наш массив:");

int [] myArray = new int [7];

for (int i = 0; i < myArray.Length; i++) 
{
    myArray [i] = new Random().Next(0,10); 
}
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Копия нашего массива:");
int [] myCopyArray = new int [myArray.Length];
for (int i = 0; i <myArray.Length; i++)
{
   myCopyArray[i] = myArray [i];
   Console.Write(myCopyArray[i] + " ");

}
Console.WriteLine();




