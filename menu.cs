using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal static class menu
    {
        static int rep = 0;
        static int select = 0;
        static int rep2 = 0;

        static menu()
        {

        }

        


        public static void menupri()
        {
            vehiculos vehi = new vehiculos();
            tipo tip = new tipo();
            vendedores vendis= new vendedores();


            do
            {
                Console.WriteLine("Escoja la opcion que necesite \n " +
                                      " 1. Vehiculos \n" +
                                      " 2. Ventas \n" +
                                      " 3. Reportes \n" +
                                      " 4. Salir \n");
                select = int.Parse(Console.ReadLine());
                if (select == 1)
                {

                    do
                    {

                        Console.WriteLine("menu para vehiculo\n" +
                            "1. agregar vehiculo\n" +
                            "2. modificar vehiculo \n" +
                            "3. consultar vehiculo\n" +
                            "4. Volver\n");
                        select = int.Parse(Console.ReadLine());
                        if (select == 1)
                        {
                            vehi.agrvehi();
                        }
                        else if (select == 2)
                        {

                        }
                        else if (select == 3)
                        {

                        }
                        else if (select == 4)
                        {
                            rep2 = 1;
                        }
                        else
                        {
                            Console.WriteLine("ingrese una opcion valida del 1 al 4");
                            Console.WriteLine("Desea realizar otro tramite: \n" +
                                "1=Si   2= No");
                            rep2 = int.Parse(Console.ReadLine());

                        }


                    } while (rep2 == 0);



                }
                else if (select == 2)
                {



                }
                else if (select == 3)
                {
                    Console.WriteLine("Reportes");
                    Console.WriteLine("reporte de vehiculos");
                    vehi.listasVTG();
                    Console.WriteLine("Reporte de vendedores");
                    vendis.listadovendedores();
                    Console.WriteLine("Reporte de vehiculos");
                    tip.listasve();
                }
                else if (select == 4)
                {


                }
                else
                {






                }


            } while (rep == 0);
        }
    }
}
