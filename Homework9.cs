namespace Homework9;
using System;

public class Student {
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();
    public Student(int id, string name) {
        this.studentID = id;
        this.studentName = name;
        studentList.Add(this);
    }
    public void PrintInfo() {
        Console.WriteLine("Student ID: " + studentID + ", Student Name: " + studentName);
    }
    public string GetName() {
        return studentName;
    }
}
class Program {
    static void Main(string[] args) {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double> {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };
        if (!gradebook.ContainsKey("Tom")) {
            gradebook.Add("Tom", 3.3);
        }
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values) {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA}");

        foreach (var student in Student.studentList) {
        if (gradebook[student.GetName()] > averageGPA) {
            student.PrintInfo();
            }
        }
    }
}