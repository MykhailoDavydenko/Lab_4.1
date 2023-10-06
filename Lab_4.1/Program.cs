// Lab_04.1.cpp
// Давиденко Михайло
// Лабораторна робота № 4.1
// Цикли
// Варіант 7

int k, N, i;
double S;
Console.WriteLine("k= "); k= int.Parse(Console.ReadLine());
Console.WriteLine("N= "); N = int.Parse(Console.ReadLine());
S = 0;
i = k;
while (i <= N)
{
    S += 1.0 / ((2 * k + 1) * (2 * k + 1));
    i++;
}
Console.WriteLine(S);

S = 0;
i = k;
do
{
    S += 1.0 / ((2 * k + 1) * (2 * k + 1));
    i++;
} while (i <= N);
Console.WriteLine(S);

S = 0;
for (i = k; i <= N; i++)
    S += 1.0 / ((2 * k + 1) * (2 * k + 1));
Console.WriteLine(S);

S = 0;
for (i = N; i >=k; i--)
    S += 1.0 / ((2 * k + 1) * (2 * k + 1));
Console.WriteLine(S);
