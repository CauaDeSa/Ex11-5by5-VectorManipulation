int size = 10;
int[] numbers = new int[size];
int[] even = new int[size + 1];
int[] odd = new int[size + 1];
even[0] = odd[0] = 0;

Console.WriteLine("\nNumbers insertion");
for (int i = 0; i < size; i++)
{
    Console.Write($"Type {i + 1}° number: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nVector");

for (int i = 0; i < size; i++)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\n\nBackwards");

for (int i = size - 1; i >= 0; i--)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\n\nHalf vector");

for (int i = 0;i < size / 2; i++)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\n\nStoring even numbers");

for (int i = 0; i < size; i++)
{
    if (numbers[i] % 2 == 0)
        even[++even[0]] = numbers[i];
}

Console.WriteLine("\nStoring odd numbers");

for (int i = 0, j = 0; i < size; i++)
{
    if (numbers[i] % 2 != 0)
        odd[++odd[0]] = numbers[i];
}

Console.WriteLine("\nEven numbers");

for (int i = 1; i <= even[0]; i++)
{
    Console.Write($"{even[i]} ");
}

Console.WriteLine("\n\nOdd numbers");

for (int i = 1; i <= odd[0]; i++)
{
    Console.Write($"{odd[i]} ");
}

Console.WriteLine("\n\nPress any key to exit...");
Console.ReadKey();