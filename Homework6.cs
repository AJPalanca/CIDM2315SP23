namespace Homework6;
public class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public Professor(string name, string teachingClass, double initialSalary)
    {
        profName = name;
        classTeach = teachingClass;
        salary = initialSalary;
    }

    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

public class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public Student(string name, string enrolledClass, double grade)
    {
        studentName = name;
        classEnroll = enrolledClass;
        studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Professor alice = new Professor("Alice", "Java", 9000);
        Professor bob = new Professor("Bob", "Math", 8000);

        Student lisa = new Student("Lisa", "Java", 90);
        Student tom = new Student("Tom", "Math", 80);

        Console.WriteLine($"Professor {alice.profName} teaches {alice.classTeach} and the salary is: {alice.GetSalary()}");
        Console.WriteLine($"Professor {bob.profName} teaches {bob.classTeach} and the salary is: {bob.GetSalary()}");

        Console.WriteLine($"Student {lisa.studentName} enrolls {lisa.classEnroll} and the grade is: {lisa.GetGrade()}");
        Console.WriteLine($"Student {tom.studentName} enrolls {tom.classEnroll} and the grade is: {tom.GetGrade()}");

        double salaryDifference = Math.Abs(alice.GetSalary() - bob.GetSalary());
        Console.WriteLine($"The salary difference between Alice and Bob is: {salaryDifference}");

        double totalGrade = lisa.GetGrade() + tom.GetGrade();
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");
    }
}