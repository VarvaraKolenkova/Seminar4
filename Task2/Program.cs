// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int result = 0;

for (; number !=0; number/=10)
{
    int a = number%10;
    result+=a;
}
Console.WriteLine(result);