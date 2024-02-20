namespace Homework5Q1;

class Program
{
    static void Main(string[] args)
{
        Console.WriteLine("Please input the first number:");
        short number1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second number:");
        short number2 = Convert.ToInt16(Console.ReadLine());

        short largest = number1;

        if (number2 > largest)
        {
            {
                largest = number2;
            }
        }
        else if (number2 > largest)
        {
            largest = number2;
        }
    
        Console.WriteLine($"a = {number1}; b = {number2};");
        Console.WriteLine("The largest number is: " + largest);
    }
}
