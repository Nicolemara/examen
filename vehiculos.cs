using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class vehiculos
    {
        static int[] costo = new int[5];
        static String[] marca = new String[5];
        static String[] codigo = new String[5];
        static String[] modelo = new String[5];

        public vehiculos()
        {

        }
        public void agrvehi()
        {

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Ingrese el codigo del vehiculo: ");
                codigo[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la marca del vehiculo: ");
                marca[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el costo del Vehiculo: ");
                costo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el modelo del vehiculo:");
                modelo[i] = Console.ReadLine();
            }
        }

        public void modi()
        {

        }

        public void condul()
        {

        }

        public void listasVTG()
        {



            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("El codigo del Vehiculo: " + codigo[i]);



                Console.WriteLine("La marca del Vehiculo: " + marca[i]);



                Console.WriteLine("El modelo del Vehiculo es: " + modelo[i]);



                Console.WriteLine("El costo del Vehiculo es: " + costo[i]);



            }


        }
    }
}

