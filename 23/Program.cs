// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125.
Console.WriteLine("Пожалуйста введите число: ");
string indexString = Console.ReadLine()!;
int index = int.Parse(indexString);
int variable = 1;
Console.WriteLine("Результат рассчета: ");
if (index <= 0)
Console.WriteLine("Просьба ввести число больше нуля.");
while (variable <= index)
{
    Console.WriteLine(variable*variable*variable);
    variable += 1;
}