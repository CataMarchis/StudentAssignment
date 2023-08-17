using StudentAssignment;

Console.Write("Student name and age: ");
string a = Console.ReadLine();
int b = Convert.ToInt32(Console.ReadLine());
Student student = new Student(a, b);
Console.WriteLine(student.Info);

Console.Write("Student name and age: ");
string c = Console.ReadLine();
int d = Convert.ToInt32(Console.ReadLine());
Student student1 = new Student(c, d);
Console.WriteLine(student1.Info);

Console.Write("Student name and age: ");
string x = Console.ReadLine();
int y = Convert.ToInt32(Console.ReadLine());
Student student2 = new Student(x, y);
Console.WriteLine(student2.Info);

Console.WriteLine(" {0} has the following mark: ", student.name);
student.Mark = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" {0} has the following mark: ", student1.name);
student1.Mark = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The average mark of our students is: ");
student2.averageMarks();

/*

int nrOfstudents = 3;

for(int i = 0; i < nrOfstudents; i++)
{
    Console.Write("Student name and age: ");
    string a = Console.ReadLine();
    int b = Convert.ToInt32(Console.ReadLine());
    Student student = new Student(a, b);
    Console.WriteLine(student.Info);
    Console.Write(" {0} has the following mark: ", student.name);
    student.Mark = Convert.ToDouble(Console.ReadLine());
    if(i == nrOfstudents - 1)
    {
        Console.WriteLine("The average mark of our students is: ");
        student.averageMarks(); 
    }
}

*/