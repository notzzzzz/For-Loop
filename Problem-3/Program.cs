﻿//Sum Numbers

int count = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 1; i <= count; i++)
{
    double number = double.Parse(Console.ReadLine());
    sum += number;
}
Console.WriteLine(sum);