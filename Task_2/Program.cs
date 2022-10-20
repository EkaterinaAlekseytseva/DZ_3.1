//Напишите программу, которая на вход принимает (целых) два числа и выдаёт (в терминале), какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int number_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int number_2 = int.Parse(Console.ReadLine()!);

if(number_1 > number_2)
{
    Console.Write("max = ");
    Console.WriteLine(number_1);
    Console.Write("min = ");
    Console.WriteLine(number_2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(number_2);
    Console.Write("min = ");
    Console.WriteLine(number_1);
}