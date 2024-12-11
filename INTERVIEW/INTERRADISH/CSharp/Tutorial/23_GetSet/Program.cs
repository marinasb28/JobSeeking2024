namespace Tutorial
{
    public static class GetSet
    {
        public class Person
        {
            private string name;
            public int age {get; set;}
            public int birthMonth {get; set;}

            // Constructor for the class
            public Person(string name, int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }

            public void setName(string name)
            {
                this.name = name;
            }
            public string getName()
            {
                return this.name;
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Marina",23,7);
            Console.WriteLine($"Name: {person.getName()}, Age: {person.age}, Birth Month: {person.birthMonth}");

            Console.WriteLine($"Name: {person.getName()}");

        }
    }
}