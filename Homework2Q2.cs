namespace Homework2Q2;

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

        short smallest = number1;

        if (number2 < smallest)
        {
            if (number2 < number3)
            {
                smallest = number2;
            }
            else
            {
                smallest = number3;
            }
        }
        else if (number3 < smallest)
        {
            smallest = number3;
        }

        Console.WriteLine("The smallest number is: " + smallest);
    }
}
