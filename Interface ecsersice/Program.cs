using Interface_ecsersice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("התוכנית מתחילה לרוץ");

        List<Person> list = new List<Person>();

        list.Add(new Student("Student", "anit", "nakesh", new DateTime(1990, 1, 1)));
        list.Add(new Teacher("Teacher", "avi", "ron", new DateTime(1995, 1, 1)));
        foreach (var item in list)
        {
            if (item is Student)
            {
                Student student = (Student)item;
                Console.WriteLine(student.GetRole());
            }
            else if (item is Teacher)
            {
                Teacher teacher = (Teacher)item;
                Console.WriteLine(teacher.GetRole());
            }

        }
    }

}