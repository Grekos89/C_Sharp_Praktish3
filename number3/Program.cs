//Напишите програму которая принемает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N
int number = new Random().Next(1, 20);
System.Console.WriteLine($"number = {number}");

for(int i = 1; i <= number; i++)
{
    System.Console.WriteLine(Math.Pow(i, 2));
}