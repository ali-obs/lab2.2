Console.Write("Enter n (1-10): ");
int n = int.Parse(Console.ReadLine()!);

if (n >= 1 && n <= 10)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{n} x {i} = {n * i}");
    }
}
else
{
    Console.WriteLine("Please enter a number between 1 and 10.");
}
