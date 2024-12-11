namespace Tutorial
{
    public static class TriangleArea
    {
        static double Area(double height, double width)
        {
            return (height*width)/2;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter triangle's height: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Enter triangle's wdth: ");
            double w = double.Parse(Console.ReadLine());

            double resultA = Area(h, w);
            Console.WriteLine($"Triangle's area: {resultA}");
        }
    }
}