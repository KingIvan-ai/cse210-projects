using System;

class Program
{
    static void Main(string[] args)
    {
        School school = new School("BYU-Idaho");

        school.AddStudent(new Student("Ivan", "A"));
        school.AddStudent(new Student("Emma", "B+"));
        school.AddStudent(new Student("Noah", "A-"));

        school.DisplayAll();
    }
}