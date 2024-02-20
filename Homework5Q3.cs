namespace Homework5Q3;

class Program
{
    static void Main(string[] args)
    {
    createAccount();
    }
    static bool checkAge(int birthYear)
    {
    int ageIn2024 = 2024 - birthYear;
    if (ageIn2024 >= 18)
    {
    return true;
    }
    else
    {
    return false;
    }
}
    static void createAccount()
    {
        Console.WriteLine("Please input your username:");
        string username = Console.ReadLine();

        Console.WriteLine("Please input your password:");
        string password = Console.ReadLine();

        Console.WriteLine("Please input your password again:");
        string confirmPassword = Console.ReadLine();

        Console.WriteLine("Please input your birth year:");
        int birthYear = Convert.ToInt16(Console.ReadLine());

        if (checkAge(birthYear))
        {
        if (password == confirmPassword)
        {
        Console.WriteLine("Account is created successfully.");
        }
        else
        {
        Console.WriteLine("Wrong password.");
        }
        }
        else
        {
        Console.WriteLine("Could not create an account.");
        }
    }

}
