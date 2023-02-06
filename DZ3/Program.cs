/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число:");
var number = int.Parse(Console.ReadLine());
var result = number / 2;    
if (number % 2 == 0)
{
    Console.WriteLine("Введенное Вами число является четным");
}
else Console.WriteLine("Введенное Вами число является нечетным");
