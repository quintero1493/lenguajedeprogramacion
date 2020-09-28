using System;

namespace ejemplo1
{
    class Operaciones
    {
        //Atributos (propiedades)

        public      int             numero1                            { get; set; }
        //mod acc   tipo de dato    nombre propiedad (atributo)     get entrega el valor set recibe el valor. 
        //public es el modificador de acceso y quiere decir que cualquier clase puede acceder a ella.
        //set o get son metodos para recibir(set) y para entregar (get) el valor de la propiedad

        public int numero2 { get; set; }


        //Metodos (funciones)
        /*public      void            nuestraSuma(int n1, int n2)
        {
        //mod acc   tipoRetorno    nombreMetodo (args o param)     get entrega el valor set recibe el valor.
        int suma = n1 + n2;
        Console.WriteLine($"La suma de {n1} y {n2} es {suma}");
        }*/ 
    //}
//}
    
    // ejemplo 2 seprar responsabilidades en los metodos
public int calcularSuma(int n1, int n2)
        {
            int resultadoSuma = 0;
            resultadoSuma = n1 + n2;
            return resultadoSuma;
        }

        public void imprimirSuma(){

            Console.WriteLine("la suma es: " +
            calcularSuma(numero1, numero2)
            );
        }
    }
}


        
        
         