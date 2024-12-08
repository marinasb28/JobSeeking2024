namespace T2
{
    public static class ObjMethods
    {
        public static void Main(string[] args)
        {
            // Crear el primer estudiante y mostrar información
            Student student1 = new Student("Marina", "Engineering", 2.9);
            Console.WriteLine($"Student 1: {student1.name}, {student1.major}, GPA: {student1.gpa}");
            Console.WriteLine($"Is Student 1 a Honors Student? {student1.isHonors()}");

            // Crear el segundo estudiante y mostrar información
            Student student2 = new Student("Adrian", "Engineering", 4.5);
            Console.WriteLine($"Student 2: {student2.name}, {student2.major}, GPA: {student2.gpa}");
            Console.WriteLine($"Is Student 2 a Honors Student? {student2.isHonors()}");
        }
    }
}