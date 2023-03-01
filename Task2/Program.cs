// Задача 2: 
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// Примеры:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите 2 целых числа. Первое: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И второе: ");
int numB = Convert.ToInt32(Console.ReadLine());
int max = numA;
int min = numB;
int container = 0;
if(numA < numB)
{
    container = numA;
    max = numB;
    min = container;
}
Console.WriteLine("Максимальное значение из введенных " + max);
Console.WriteLine("А минимальное " + min);