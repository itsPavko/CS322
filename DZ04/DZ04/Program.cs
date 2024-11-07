//Z1
Console.WriteLine("Zadatak 1");

int n = 500;
int sum = 0;

for (int i = 0; i < n; i++)
{
	if (i % 2 == 1)
	{
		sum += i;
	}
}

Console.WriteLine(sum);

//Z2
Console.WriteLine("Zadatak 2");

for (int j = 16; j >= 8 ; j--)
{
	Console.WriteLine(j * 2);
}

//Z3
Console.WriteLine("Zadatak 3");
string s = "12345";
char[] chars = s.ToCharArray();
Array.Sort(chars);
string s1 = new string(chars);

if (Int32.TryParse(s, out int m))
{
	if (m < 1000000000)
	{
		if (s == s1)
		{
			Console.WriteLine("Cifre broja su rastuce");
		}
		else
		{
			Console.WriteLine("Cifre broja su nisu rastuce");
		}
	}
	else
	{
		Console.WriteLine("Broj unet je veci od milijardu");
	}

}
else
{
	Console.WriteLine("Nije unet broj");
}


