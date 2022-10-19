using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class vendedores
    {

        Dictionary<string, string> vendedor = new Dictionary<string, string>();

        public vendedores()
        {

        }
        public void listadovendedores()
        {

            vendedor.Add("E-A","Nicole");
            vendedor.Add("E-B","Xochil");

            Console.WriteLine(" El nombre del primer vendedor;  "+ vendedor["E-A"]);
            Console.WriteLine(" El nombre del segundo vendedor;  " + vendedor["E-B"]);
        }
        public String conver(String Codigo)
        {

            if (vendedor.TryGetValue(Codigo,out string resultado))
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("No esta");


            }

            return Codigo;
        }


    }

   

}
