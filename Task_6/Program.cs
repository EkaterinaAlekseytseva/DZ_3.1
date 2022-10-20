//Напишите программу, которая на вход принимает (целое) число и выдаёт (В терминале), является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Программа нахождения четного числа");
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
//int n = number%10;
//Console.WriteLine("Остаток" + number%10);

if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}