namespace Homework4Q2;

class Program
{
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N: {N}, Shape: {shape}");
        if (shape.ToLower() == "left")
        {
        for (int row = 1; row <= N; row++)
        {
        for (int col = 1; col <= row; col++)
        {
        Console.Write("*");
        }
        Console.WriteLine();
        }
        }
        else if (shape.ToLower() == "right")
        {
        for (int row = 1; row <= N; row++)
        {
        for (int space = 1; space <= N - row; space++)
        {
        Console.Write(" ");
        }
        for (int col = 1; col <= row; col++)
        {
        Console.Write("*");
        }
        Console.WriteLine();
        }
        }
        else
        {
        Console.WriteLine("Shape not recognized. Please enter 'left' or 'right'.");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the shape: ");
        string shape = Console.ReadLine();

        PrintTriangle(N, shape);
    }
}