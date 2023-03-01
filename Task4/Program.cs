// Задача 4: 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// Примеры:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три любых целых числа. Первое: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И третье: ");
int numC = Convert.ToInt32(Console.ReadLine());
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int max = Max(numA, numB, numC);
Console.WriteLine("Максимальное введенное значение " + max);