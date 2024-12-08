namespace T2
{
    public class Student
    {
        // Atributos de la clase
        public string name, major;
        public double gpa;

        // Constructor para inicializar atributos
        public Student(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            this.gpa = gpa;
        }

        // Método para verificar si el estudiante tiene honores
        public bool isHonors()
        {
            return this.gpa >= 3.5;
        }
    }
}
