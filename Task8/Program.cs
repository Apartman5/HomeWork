// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// Примеры:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int evenNumber = 0;
Console.WriteLine("Введите любое целое число ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0) 
{
    number = -number; 
}

if(number % 2 > 0) 
{
    evenNumber = number - 1;
}
int count = 0;

while (evenNumber > count)
{
    count += 2;
    Console.Write(" " + count);
}