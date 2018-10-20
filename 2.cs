using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaDesinfectante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: "); //Solicitando el primer número
            int a = int.Parse(Console.ReadLine()); //Se convierte en entero y se almacena en a
            Console.WriteLine("Ingrese el segundo número"); //Solicitando el segundo número
            int b = int.Parse(Console.ReadLine()); //Se convierte en entero y se almacena en b

            if (a > b) //Condicional (Si a es mayor que b)
            {
                Console.WriteLine("El mayor es " + a); //Se muestra el texto unido con a
                Console.WriteLine("El menor es " + b); //Se muestra el texto unido con b
            }
            else if(a < b) //Condicional (Si a es menor que b)
            {
                Console.WriteLine("El mayor es " + b); //Se muestra el texto unido con b
                Console.WriteLine("EL menor es " + a); //Se muestra el texto unido con a
            }
            else //De lo contrario
            {
                Console.WriteLine("Los valores son iguales");  //Los dos valores son iguales
            }

            Console.ReadKey();

        }
    }
}
