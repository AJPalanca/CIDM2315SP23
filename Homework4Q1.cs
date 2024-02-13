namespace Homework4Q1;

class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 5;

        Console.WriteLine($"a = {a}; b={b}");

        int largestNumber = FindLargestNumber(a, b);

        Console.WriteLine($"The largest number is:{largestNumber}");
    }

    static int FindLargestNumber(int num1,int num2)
    {
        if (num1 > num2)
        {
        return num1;
        }
        else
        {
        return num2;
        }
    }
}
