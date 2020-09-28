using System;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hola Perros HP's");
            //vamos a sumar dos numero de forma que primero pida los numeros para sumar
            // y luego realice la suma
            //1. la vamos a hacer de forma estructurada
            //2. hacemos la aplicacion con programacion orientada a objetos POO

            /* FORMA ESTRUCTURADA
            Console.WriteLine("Ingrese el Pirmer Numero"); //debajo de esta intruccion debo
                                            //decirle que me permita ingresar o escribir el numero
            int num1 = int.Parse(Console.ReadLine());            
            //Console.WriteLine ("El numero es: " + num1);

            Console.WriteLine("Ingrese el Segundo Numero");
            int num2 = int.Parse(Console.ReadLine());            
            
            //int suma = num1 + num2; //una forma
            //Console.WriteLine($"la suma de {num1} y {num2} es {suma}"); // una forma


            Console.WriteLine($"La suma de {num1} y {num2} es {num1 + num2}"); //dos forma
            */

            //FORMA ORIENTADA A OBJETOS

            Console.WriteLine("Ingrese el Pirmer Numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo Numero");
            int num2 = int.Parse(Console.ReadLine());

            //vamos a instanciar la clase Operaciones
            //Y es hijo de la class Operaciones - que se llama myOperations - va a tener un nuevo objeto - el construcor Operaciones()
            Operaciones                                 myOperations =             new                        Operaciones() {
                numero1 = num1,
                numero2 = num2,
            };
            
            //Verificar el valor que tiene almacenado la variable
            /*Console.WriteLine("el primer numero es: " + myOperations.numero1);
            Console.WriteLine("el segunro numero es: " + myOperations.numero2);*/

            //llevar el valor como parametro a un metodo
            // para esto debo llamar el metodo de la clase
            //mediante su instancia (un objeto)

            //myOperations.nuestraSuma(myOperations.numero1, myOperations.numero2);

            //ejemplo 2 separar responsabilidades en los metodos
            myOperations.imprimirSuma();     
        }
    }
}
