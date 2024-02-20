namespace Homework5Q2;

class Program
{
    static void Main(string[] args)
     {
        Console.WriteLine("Please input the first number:");
        short number1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second number:");
        short number2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the third number:");
        short number3 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the fourth number:");
        short number4 = Convert.ToInt16(Console.ReadLine());

        short largest = number1;

        if (number2 > largest)
        {
            largest = number2;
        }
        if (number3 > largest)
        {
            largest = number3;
        }
        if (number4 > largest)
        {
            largest = number4;
        }
        Console.WriteLine($"a = {number1}; b = {number2}; c = {number3}; d = {number4};");
        Console.WriteLine("The largest number is: " + largest);
    }
}
