
namespace DAY1
{
    public class StudentGrade
    {
        static (double, string) avgGrade(List<double> grades)
        {
            double sum = 0;
            foreach(var grade in grades)
            {
                sum += grade;
            }
           double avg = sum / grades.Count;

            string letterGrade = "";
            if (avg >= 90)
            {
                letterGrade = "A";
            }
            else if (avg >= 80)
            {
                letterGrade = "B";
            }
            else if (avg >= 70)
            {
                letterGrade = "C";
            }
            else if (avg >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            return (avg, letterGrade);
        }
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 85,90,78,92};
            
            var result = avgGrade(grades);
            Console.WriteLine($"Average grade: {result.Item1}, Letter grade: {result.Item2}");
        }
    }
}