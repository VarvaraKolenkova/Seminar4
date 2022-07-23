// Цикл, который принимает на вход 2 числа (А и В) и возводит число А в степень В
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());

int result = a;
for (int i = 2; i <= b; i++)
{
    result*=a;
}
Console.WriteLine($"{a} в степени {b} = {result}");