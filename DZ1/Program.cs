/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */


Console.WriteLine("Введите первое число");
var a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
var b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a>b? "Первое число больше второго" : "Второе число больше первого");

// git remote add origin https://github.com/emik955/HomeWork1.git
// git branch -M main
// git push -u origin main