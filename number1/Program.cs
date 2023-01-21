// Напишите программу которая по заданной четверти
//  показывает диапазон возможных координат точек этой четврти (x и y).
int number  = new Random().Next(1,5);
Console.WriteLine(number);

if(number == 1)
{
    Console.WriteLine("x = (0, + бесконечность) y = (0, +бесконечность)");  
}
else if(number == 2)
{
    Console.WriteLine("x = (0, - бесконечность) y = (0, +бесконечность)");
}
else if(number == 3)
{
    Console.WriteLine("x = (0, - бесконечность) y = (0, -бесконечность)");
}
else if(number == 4)
{
    Console.WriteLine("x = (0, + бесконечность) y = (0, +бесконечность)");
}
else if(number < 0 || number > 4)
{
    Console.WriteLine("нет такой четверти");
}