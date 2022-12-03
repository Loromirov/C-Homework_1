/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine() ?? "";

int n = Convert.ToInt32(number);
int even = Convert.ToInt32(2);
 if (n % 2 == 0)

 {
    Console.WriteLine($"Число {n} является четным");
 }  
 else 
  {
    Console.WriteLine($"Число {n} не является четным");
  }  