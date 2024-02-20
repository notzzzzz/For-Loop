//First N Numbers Sum


int sum = 0;
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    sum += i;
}
for (int i = 1; i < num; i++)
{
    Console.Write($"{i}+");
}
Console.Write(num);
Console.Write($"={sum}");
