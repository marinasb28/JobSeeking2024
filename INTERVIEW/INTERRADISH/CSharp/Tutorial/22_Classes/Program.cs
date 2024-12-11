namespace Tutorial
{
    public static class Classes
    {
        public class Person
        {
            public string name;
            public int age;
            public int birthMonth;

            // Constructor for the class
            public Person(string name, int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }
        }

        static int futureAge(int x)
        {
            return x + 10;
        }
        static void Main(string[] args)
        {
            Person person = new Person("Marina",23,7);
            Console.WriteLine($"Name: {person.name}, Age: {person.age}, Birth Month: {person.birthMonth}");

            Console.WriteLine($"In 10 years {person.name} will be {futureAge(person.age)}");
        }
    }
}