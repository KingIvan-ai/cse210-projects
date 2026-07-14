public class Student
{
    private string _name;
    private string _grade;

    public Student(string name, string grade)
    {
        _name = name;
        _grade = grade;
    }

    public string GetInfo()
    {
        return $"{_name} - Grade: {_grade}";
    }
}