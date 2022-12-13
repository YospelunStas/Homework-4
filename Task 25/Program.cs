// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
string str1 = Console.ReadLine();
int A = int.Parse(str1);
Console.Write("Введите число B: ");
string str2 = Console.ReadLine();
int B = int.Parse(str2);
int power = 1;
for (int i = 0; i < B; i++)
{
power = power * A;
}
Console.WriteLine($"Число {A} в степени {B} = " + power);