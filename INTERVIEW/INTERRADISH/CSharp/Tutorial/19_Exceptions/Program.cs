namespace Tutorial
{
    public static class Exceptions
    {
        static void Main(string[] args)
        {
            bool valid = false;

            while (!valid)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    double num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    double num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{num1}/{num2} = {num1 / num2}");
                    valid = true;
                } catch (Exception e)
                {
                    Console.WriteLine($"An unexpected error occurred: {e.Message}");
                } 
                /*catch(DivisionException) {
                    Console.WriteLine("Cannot divide by zero.");
                }*/
                finally
                {
                    Console.WriteLine("Attempt completed.\n");
                }
            }
        }
    }
}