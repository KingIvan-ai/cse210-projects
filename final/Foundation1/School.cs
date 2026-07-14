public class School
{
    private string _name;
    private List<Student> _students;

    public School(string name)
    {
        _name = name;
        _students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Students at {_name}:");

        foreach (Student s in _students)
        {
            Console.WriteLine(s.GetInfo());
        }
    }
}