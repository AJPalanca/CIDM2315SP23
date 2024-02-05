namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Please input a letter grade");
       string letter_grade = Console.ReadLine();

        if ("A" == letter_grade)
        {
        Console.WriteLine("GPA: 4");
        }
        else if("B" == letter_grade)
        {
        Console.WriteLine("GPA: 3");
        }
        else if("C" == letter_grade)
        {
        Console.WriteLine("GPA: 2");
        }
        else if("D" == letter_grade)
        {
        Console.WriteLine("GPA: 1");
        }
        else if("F" == letter_grade)
        {
        Console.WriteLine("GPA: 0");
        }
        else 
        {
        Console.WriteLine("Wrong Letter Grade!");
        }
    
    }

}
