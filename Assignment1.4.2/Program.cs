/*
Write a class: “Student” with private data members: StudentId ( int)
StudentFname (string), StudentLname (string ), StudentGrade ( char )
and public properties for each data member.
Instantiate the class and assign data to properties. Display the data back on console.
*/
Console.WriteLine("input student information:");
Student student = new Student();
Console.Write("Student ID: ");
student.StudentId = int.Parse(Console.ReadLine());
Console.Write("First Name: ");
student.StudentFname = Console.ReadLine();
Console.Write("Last Name: ");
student.StudentLname = Console.ReadLine();
Console.Write("Grade: ");
student.StudentGrade = char.Parse(Console.ReadLine());

Console.WriteLine("\nStudent Information:");
Console.WriteLine($"ID: {student.StudentId}");
Console.WriteLine($"First Name: {student.StudentFname}");
Console.WriteLine($"Last Name: {student.StudentLname}");
Console.WriteLine($"Grade: {student.StudentGrade}");

class Student
{
    private int studentId;
    private string studentFirstname;
    private string studentLastname;
    private char studentGrade;
    
    public int StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }
    
    public string StudentFname
    {
        get { return studentFirstname; }
        set { studentFirstname = value; }
    }
    
    public string StudentLname
    {
        get { return studentLastname; }
        set { studentLastname = value; }
    }
    
    public char StudentGrade
    {
        get { return studentGrade; }
        set { studentGrade = value; }
    }
}