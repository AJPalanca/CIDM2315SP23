namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        double X = 2.5;
        double Y = 3.3;

        Console.WriteLine("X = 2.5, Y = 3.3");

        double Z = 4 * Math.Pow(X, 2) + 3 * Y;

        Console.WriteLine($"The value of Z is: {Z}");
    }
}
