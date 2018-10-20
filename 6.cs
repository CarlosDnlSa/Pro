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

            string[] CodigoArticulo = new string[5]; //Vector que almacenará el código del artículo
            int[] CantidadLitros = new int[5]; //Vector que almacena la cantidad vendida en litros
            int[] PrecioLitro = new int[5]; //Vector que guardará el precio del litro
            int[] TotalFactura = new int[5]; //Vector que almacena el total de la factura
            int Totalf = 0, con = 0; //Acumulador que guardará el total de la factura
            //Ingresando los datos a los vectores
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Código del artículo: "); //Pidiendo el código del articulo
                CodigoArticulo[i] = Console.ReadLine(); //Guardando el código como un string en el vector CodigoArticulo
                Console.WriteLine("Cantidad vendida en litros: ");//Pidiendo la cantidad vendida en litros
                CantidadLitros[i] = int.Parse(Console.ReadLine()); //Se convierte en entero y se almacena en el vector CantidadLitros
                Console.WriteLine("Precio por litro: "); //Pidiendo el precio por litro
                PrecioLitro[i] = int.Parse(Console.ReadLine()); //Se convierte en entero y se almacena en el vector PrecioLitro
                TotalFactura[i] = CantidadLitros[i] * PrecioLitro[i]; //Se múltiplican los valores CantidadLitros[i] * PrecioLitro[i] y se guarda en TotalFactura[i]
            }

            //Sumando los valores en el vector TotalFactura[]
            for(int i = 0; i < 5; i++)
            {
                Totalf = Totalf + TotalFactura[i]; //Acumulador del total de la factura
                if (TotalFactura[i] > 300000) //Buscando las facturas que tienen un valor a 300000
                {
                    con++; //Aumentando el contador cada que se cumpla la condición
                }
            }

            Console.WriteLine("La facturación total fue de: " + Totalf); //Imprimiendo la facturación total
            Console.WriteLine("Cantidad en litros vendidos del artículo 1: " + CantidadLitros[0]); //Mostrando la cantidad de litros de la factura 1 ubicada en la posición 0 del vector
            Console.WriteLine("Total facturas mayores a 300000 " + con); //Mostrando la cantidad de facturas mayores a 300000
            Console.ReadKey();

        }
    }
}
