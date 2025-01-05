// Z1

int n = 0;

for (int i = 1; i < 3000; i++)
{
    n += i;
}
Console.WriteLine(n);

// Z2

n = 0;

int j = 0;

for (int i = 0; j < 100; i++)
{
    if (i % 2 == 0)
    {
        j++;
        n += i;
    }
}

Console.WriteLine(n);

// Z3

n = 0;

for (int i = 21; i < 99; i++)
{
    if ((i % 2) == 0)
    {
        n += i;
    }
}

Console.WriteLine(n);

// Z4

n = 0;
float s = 0;

int[] a = [1, 8, 6, 8, 4, 7, 3, 45, 80];

for (int i = 0; i < a.Length; i++)
{
    n += a[i];
}

s = n / a.Length;

Console.WriteLine(n + ", " + s);

// Z5

int min = 0;
int max = 0;

min = a.Min();
max = a.Max();

Console.WriteLine(min + ", " + max);
