//Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double Prompt(string message)
{
    System.Console.Write(message);
    return double.Parse(Console.ReadLine());
}
System.Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых,");
System.Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
System.Console.WriteLine("значения b1, k1, b2 и k2 задаются пользователем.");
double k1 = Prompt("Введите k1 > ");
double k2 = Prompt("Введите k2 > ");
double b1 = Prompt("Введите b1 > ");
double b2 = Prompt("Введите b2 > ");

if (k1 == k2 && b1 == b2)
{
    System.Console.Write("Прямые совпадают !");
}
else 
if (k1 == k2 && b1 != b2)
{
    System.Console.Write("Прямые параллельны !");
}
else
{
    double coordinateX = (b2 - b1) / (k1 - k2);
    double coordinateY = (k1 * coordinateX) + b1;

    System.Console.Write($"Координаты точки пересечения [x,y] [{coordinateX}, {coordinateY}]");
}
