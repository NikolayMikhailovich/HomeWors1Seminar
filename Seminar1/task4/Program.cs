﻿// Написать программу которая на вход принимает число(N) а на выходе показывает все четные числа от 1 до (N)

Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool not = true;

Console.WriteLine("Чётные числа от 1 до " + number);
while (i <= number)
{
  if (i % 2 != 1)
  {
    Console.Write(i + ", ");
    not = false;
  }
  i++;
}
if (not)
{
  Console.WriteLine("Нет чётных чисел!");
}