/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
 из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число 1 ");
string number1 = Console.ReadLine() ?? "";

Console.WriteLine("Введите число 2 ");
string number2 = Console.ReadLine() ?? "";

Console.WriteLine("Введите число 3 ");
string number3 = Console.ReadLine() ?? "";

int a = Convert.ToInt32(number1);
int b = Convert.ToInt32(number2);
int c = Convert.ToInt32(number3);

int numbaerMax = a;

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine($"Максимальное число {a}");
    }
}
else 
    if (b > c)
{
    Console.WriteLine($"Максимальное число {b}");
}
else 
{
    Console.WriteLine($"Максимальное число {c}");
}
