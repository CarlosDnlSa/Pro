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

            Console.WriteLine("Ingrese su nombre: "); //Solicitando el nombre
            string nombre = Console.ReadLine(); //Almacenando el nombre en la variable "nombre"
            Console.WriteLine(nombre + " estas usando mi programa"); //Uniendo el texto en la varible nombre con el mensaje
            Console.ReadKey();

        }
    }
}
