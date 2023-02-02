// Задача 1
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, 
// является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число > ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 10000 && num < 99999)
{
    int num1 = num / 10000;
    Console.WriteLine(num1);
    int num2 = num % 10000 / 1000;
    Console.WriteLine(num2);
    int num4 = num % 100 / 10;
    Console.WriteLine(num4);
    int num5 = num % 10;
    Console.WriteLine(num5);
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"Введенное чило < {num} > является палиндромом");
    }
    else
    {
        Console.WriteLine($"Введенное чило < {num} > НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Число должно быть пятизначное");
}