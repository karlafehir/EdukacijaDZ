class Program
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int JMBAG { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name, int age, int jmbag)
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

        public double calculateAverage(List<int> Grades)
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
        Student student1 = new Student("Pero Peric", 20, 123456);
        Student student2 = new Student("Ana Anic", 22, 123123);

        student1.AddGrade(4);
        student1.AddGrade(5);

        double student1Average = student1.calculateAverage(student1.Grades);
        double student2Average = student2.calculateAverage(student2.Grades);
        Console.WriteLine(student1Average);
        Console.WriteLine(student2Average);
    }

}