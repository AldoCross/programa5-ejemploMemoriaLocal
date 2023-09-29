using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa5_ejemplo_memoria_Local
{
    class Program
    {
        class Volumenes
        {
            // metodos locales:
            public float PrismaRectangular(float x, float y)  // datos locales
            {
                return x*y; 
            }

            public float Cono(float a, float b) // datos locales
            {
                return (a*b)/3;
            }

        }
        static void Main(string[] args)
        {
            // captura de datos y declaracion de variables:
            float Ab,h,ab,a;
            Console.WriteLine(" ** Volumen del Prisma Rectangular ** ");
            Console.Write(" Teclee el Area de la Base: ");
            Ab = float.Parse(Console.ReadLine());
            Console.Write(" Teclee La Altura: ");
            h = float.Parse(Console.ReadLine());

            Console.WriteLine("\n ** Volumen del Cono ** ");
            Console.Write(" Teclee el Area de la Base: ");
            ab = float.Parse(Console.ReadLine());
            Console.Write(" Teclee la Altura: ");
            a = float.Parse(Console.ReadLine());

            // creacion del objeto
            Volumenes vol = new Volumenes();
            // Despliege de los resultados:
            Console.WriteLine("\n El Volumen de Prisma Rectangular es: {0}" , vol.PrismaRectangular(Ab,h));
            Console.WriteLine(" El Volumen del Cono es: {0}", vol.Cono(ab, a));
            //cierre del programa:
            Console.ReadKey();

        }
    }
}
