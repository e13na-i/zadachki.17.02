namespace _17._02.z
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student("Ivan", 18),
            new Student("Mariq", 17),
            new Student("Georgi", 20),
            new Student("Aneliq", 19),
            new Student("Petar", 16)
        };

            Console.WriteLine("Before sorting:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            BubbleSort(students);

            Console.WriteLine("\nAfter sorting by age:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void BubbleSort(List<Student> students)
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (students[j].Age > students[j + 1].Age)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }
    }
}
