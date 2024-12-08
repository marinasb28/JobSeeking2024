namespace Tutorial
{
    public static class KeyWords
    {
        static void Main(string[] args)
        {
            /* VAR:
            * detecta automáticamente el tipo de variable
            */
            var strName = "Marina";
            var numAge = 23;
            var boolVal = false;
            Console.WriteLine($"Name: {strName}, Age: {numAge}, Bool: {boolVal}");

            
            /* CONSTANT:
            * no permite ser modificada
            */
            const int age = 23;
            Console.WriteLine($"Constant age: {age}");
        }
    }
}