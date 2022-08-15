// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояния между ними в 3D  пространстве.
// A(3,6,8); B(2,1,-7) -> 15.84
// A (7,-5,0); B(1,-1,9) -> 11.53

Console.WriteLine("Введите пожалуйста координату X1");
var X1String = Console.ReadLine();
int X1 = int.Parse(X1String!);
Console.WriteLine("Введите пожалуйста координату Y1");
var Y1String = Console.ReadLine();
int Y1 = int.Parse(Y1String!);
Console.WriteLine("Введите пожалуйста координату Z1");
var Z1String = Console.ReadLine();
int Z1 = int.Parse(Z1String!);
Console.WriteLine("Введите пожалуйста координату X2");
var X2String = Console.ReadLine();
int X2 = int.Parse(X2String!);
Console.WriteLine("Введите пожалуйста координату Y2");
var Y2String = Console.ReadLine();
int Y2 = int.Parse(Y2String!);
Console.WriteLine("Введите пожалуйста координату Z2");
var Z2String = Console.ReadLine();
int Z2 = int.Parse(Z2String!);
var result = Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
Console.WriteLine("Расстояние: " + result);
