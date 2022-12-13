// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
string str = Console.ReadLine();
int sum = 0;
int i = 0;
while (i < str.Length)
{
    sum = sum + str[i];
    i++;
}
Console.WriteLine($"Сумма цифр числа = {sum}");