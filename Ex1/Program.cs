// Ввести два числа, вывести максимальное из них. 
// Три примера собраны в одну программу, последовательно.

int A = 5;
int B = 7;
int max = A;
if (A > max)
{
    max = A;
}
if (B > max)
{
 max = B;   
}
Console.Write("max = ");
Console.WriteLine(max);

int C = 2;
int D = 10;
int max2 = C;
if (C > max2)
{
    max2 = C;
}
if (D > max2)
{
 max2 = D;   
}
Console.Write("max2 = ");
Console.WriteLine(max2);

int E = -9;
int F = -3;
int max3 = E;
if (E > max3)
{
    max3 = E;
}
if (F > max3)
{
 max3 = F;   
}
Console.Write("max3 = ");
Console.WriteLine(max3);
