class Program
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string JMBAG { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name, int age, string jmbag)
        {
            Name = name;
            Age = age;
            JMBAG = jmbag;
            Grades = new List<int>();
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        public double CalculateAverage()
        {
            if (Grades.Count == 0)
            {
                return 0.0;
            }
            else
            {
                double sum = Grades.Sum();
                return sum / Grades.Count;
            }
        }
    }

    static void Main(string[] args)
    {
        Student student1 = new Student("Pero Peric", 20, "123456");
        Student student2 = new Student("Ana Anic", 22, "123123");

        student1.AddGrade(4);
        student1.AddGrade(5);

        student2.AddGrade(1);
        student2.AddGrade(5);

        double student1Average = student1.CalculateAverage();
        double student2Average = student2.CalculateAverage();
        Console.WriteLine($"Student 1 Average: {student1Average}");
        Console.WriteLine($"Student 2 Average: {student2Average}");
        Console.WriteLine();

        List<Student> studentsPassed = new List<Student>();
        Queue<Student> studentsNotPassed = new Queue<Student>();

        if (student1.Grades.Any(grade => grade == 1))
        {
            studentsNotPassed.Enqueue(student1);
        }
        else
        {
            studentsPassed.Add(student1);
        }

        if (student2.Grades.Any(grade => grade == 1))
        {
            studentsNotPassed.Enqueue(student2);
        }
        else
        {
            studentsPassed.Add(student2);
        }

        Console.WriteLine("Students who Passed:");
        foreach (var student in studentsPassed)
        {
            Console.WriteLine($"Name: {student.Name}, JMBAG: {student.JMBAG}");
        }

        Console.WriteLine("\nStudents who Did Not Pass:");
        foreach (var student in studentsNotPassed)
        {
            Console.WriteLine($"Name: {student.Name}, JMBAG: {student.JMBAG}");
        }
    }
}

