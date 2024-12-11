namespace Tutorial
{
    public static class Structures
    {
        //nos permite agrupar varios tipo de data en una variable
        public struct Person
        {
            public string name;
            public int age;
            public int birthMonth;

            // Constructor for the structure
            public Person(string name, int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Marina",23,7);
            Console.WriteLine($"Name: {person.name}, Age: {person.age}, Birth Month: {person.birthMonth}");
        }
    }
}