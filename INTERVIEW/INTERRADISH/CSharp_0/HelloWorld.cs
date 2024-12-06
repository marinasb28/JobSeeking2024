using System;
using System.Collections.Generic;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        // static -> fuera del main
        static void myFunction()
        {
            Console.WriteLine("Esto es una función.");
        }

        static int multFunction(int x)
        {
            return x * 2;
        }
        static void Main(string[] args)
        {
            // ** STRINGS ** \\
            string myString = "How are you doing?";
            Console.WriteLine("Hello, World!");
            Console.WriteLine(myString);

            // ** NUMBERS ** \\
            int myInt = 7;
            Console.WriteLine($"Our value is {myInt}");
            myInt += 1;
            Console.WriteLine($"Adding 1: {myInt}");

            // Float -> para ocupar menos memoria
            float myFloat = 6.5f;
            Console.WriteLine($"Float value: {myFloat}");

            // Double -> nuestro verdadero float
            double myDouble = 7.5;
            Console.WriteLine($"Decimal value: {myDouble}");

            // ** BOOLEANS ** \\
            bool myBool = true;
            Console.WriteLine($"Boolean value: {myBool}");

            // ** GENERAL TYPE ** \\
            /*
            Dynamic -> variable que admite cualquier tipo de datos
            var -> también acepta cualquier tipo de datos
            */
            dynamic myDinamic = 6;
            Console.WriteLine(myDinamic);
            myDinamic = "Ahora soy una string";
            Console.WriteLine(myDinamic);
            myDinamic = 6.5;
            Console.WriteLine(myDinamic);

            // Constantes: debo especificar el tipo de dato
            const string myConst = "Soy una constante";
            Console.WriteLine(myConst);

            // ** ESTRUCTURAS ** \\
            // Array; longitud fija
            var myAarray = new string[] { "Marina", "Suárez" };
            foreach (var name in myAarray)
            {
                Console.WriteLine($"Hola, {name}!");
            }

            // Dictionary
            var myDict = new Dictionary<string, int> 
            {
                {"Marina", 23},
                {"Lucky", 12}
            };
            Console.WriteLine(myDict["Marina"]);

            /* HashSet:
            - similar a lista
            - obvia valores repetidos
            */
            var mySet = new HashSet<string> { "Marina", "Suárez" };

            // Tupla
            var myTuple = ("Marina", "Suárez");
            Console.WriteLine(myTuple);

            // ** BUCLES **\\

            // for NORMAL
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hola, mundo! {i}");
            }

            // foreach: recorre estructuras ya formadas
            foreach (var myItem in myAarray)
            {
                Console.WriteLine(myItem);
            }

            // ** FLUJOS **\\
            /*
            AND -> &&
            OR -> ||
            NOT ->!
            */

            if(myInt == 5)
            {
                Console.WriteLine("El número es 5");
            }else if(myInt == 12){
                Console.WriteLine("El valor es intermedio");
            }else 
            {
                Console.WriteLine($"El número no es 5, es {myInt}");
            }


            // ** FUNCIONES **\\
            myFunction();
            Console.WriteLine($"Multiplicación 5x2: {multFunction(5)}");
            
        }
    }
}

/* DOTNET COMMANDS
* Crear proyecto -> dotnet new console
* Ejecutar archivo -> dotnet run
*/