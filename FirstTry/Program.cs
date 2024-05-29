// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите размер: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("  ");
    }
    Console.Write("***\n");
    for (int j = 0; j < i; j++)
    {
        Console.Write("  ");
    }
    Console.Write("  *\n");
}

