
Console.Write("Введите ЛЮБОЕ число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write( number + " Это чётное число ");
}
else
{
    Console.Write( number + " Это нечётное число ");
}