// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine ("Введите пожалуйста пятизначное число для того, чтобы узнать является ли оно палиндромом:");

string? indexString = Console.ReadLine ();

int index = int.Parse(indexString!);

if (index < 0)
    index *= (-1);

if (index > 9999 && index < 100000)
{
int index1 = index;
int index2 = 0;

while (index > 0)
{
    int a = index % 10;
    index2 = index2 * 10 + a;
    index = index / 10;
}

if (index1 == index2)
Console.WriteLine("Число " + index1 + " является палидромом.");
else
    Console.WriteLine("Число " + index1 + " не является палидромом.");
}
else
{
    Console.WriteLine("Введено не пятизначное число. Попробуйте снова.");
}